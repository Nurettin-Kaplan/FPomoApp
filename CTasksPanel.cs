using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FPomoApp
{
    public partial class CTasksPanel : UserControl
    {
        public CTasksPanel()
        {
            InitializeComponent();
        }

        private void CTasksPanel_Load(object sender, EventArgs e)
        {
            PullData();
            DrawGraphic();
        }

        private void DrawGraphic()
        {
            // 1. Chart bileşenini temizle
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();

            // 2. Yeni bir ChartArea ekleyelim
            ChartArea chartArea = new ChartArea("PieArea");
            chart1.ChartAreas.Add(chartArea);

            // 3. Yeni bir Seri (Series) ekleyelim
            Series series = new Series
            {
                Name = "Görevler",
                ChartType = SeriesChartType.Pie, // Pasta Grafiği
                IsValueShownAsLabel = true // Değerleri göster
            };

            // 4. FlowLayoutPanel içindeki görevlerin renklerini ve sayılarını belirleyelim
            int acilGorevSayisi = 0;
            int ortaGorevSayisi = 0;
            int rahatGorevSayisi = 0;

            foreach (Control taskPanel in FLCTasksPanel.Controls)
            {
                if (taskPanel is Panel panel)
                {
                    foreach (Control innerCtrl in panel.Controls)
                    {
                        if (innerCtrl is PictureBox pbox && pbox.Image != null)
                        {
                            if (pbox.Image == Properties.Resources.redCircle)
                                acilGorevSayisi++;
                            else if (pbox.Image == Properties.Resources.yellowCircle)
                                ortaGorevSayisi++;
                            else if (pbox.Image == Properties.Resources.greenCircle)
                                rahatGorevSayisi++;
                        }
                    }
                }
            }
            MessageBox.Show($"Acil: {acilGorevSayisi}, Orta: {ortaGorevSayisi}, Rahat: {rahatGorevSayisi}");

            // 5. Pasta grafiğine veri ekleme
            if (acilGorevSayisi > 0)
                series.Points.AddXY("Acil", acilGorevSayisi);
            if (ortaGorevSayisi > 0)
                series.Points.AddXY("Önemli", ortaGorevSayisi);
            if (rahatGorevSayisi > 0)
                series.Points.AddXY("Sıradan", rahatGorevSayisi);

            // 6. Pasta grafiğine renk atama (PictureBox renklerine uygun olacak şekilde)
            if (series.Points.Count > 0)
            {
                int index = 0;
                if (acilGorevSayisi > 0)
                    series.Points[index++].Color = Color.Red;
                if (ortaGorevSayisi > 0)
                    series.Points[index++].Color = Color.Yellow;
                if (rahatGorevSayisi > 0)
                    series.Points[index++].Color = Color.Green;
            }

            // 7. Seriyi Chart'a ekleyelim
            chart1.Series.Add(series);

            // 8. Grafik görünüm ayarları
            chart1.Titles.Add("Görev Dağılımı");
            chart1.Legends.Add(new Legend("Legend"));
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true; // 3D efekti aç
        }

        private void AddTask(FlowLayoutPanel panel, string taskName, int taskLevel)
        {
            Panel taskPanel = new Panel
            {
                BackColor = Color.FromArgb(25, 25, 25),
                Width = panel.Width - 20,
                Padding = new Padding(5),
                Margin = new Padding(3),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            PictureBox PBoxTaskLevel = new PictureBox
            {
                Image = Properties.Resources.greenCircle,
                Size = new Size(30, 30),
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Left,
                Tag = "checkboxBlank"
            };

            if (taskLevel == 1)
            {
                PBoxTaskLevel.Image = Properties.Resources.greenCircle;
            }
            else if (taskLevel == 2)
            {
                PBoxTaskLevel.Image = Properties.Resources.yellowCircle;
            }
            else if (taskLevel == 3)
            {
                PBoxTaskLevel.Image = Properties.Resources.redCircle;
            }

            Label LblTask = new Label
            {
                Text = taskName,
                AutoSize = true, // AutoSize false yapılıyor
                Width = panel.Width - 50, // Sabit genişlik
                MaximumSize = new Size(panel.Width - 50, 0), // Panel genişliğine uyumlu
                Padding = new Padding(5),
                Font = new Font(Font, FontStyle.Bold | FontStyle.Strikeout),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.TopLeft,
                //Height = 30 // Başlangıç yüksekliği
            };

            // Yüksekliği metnin uzunluğuna göre otomatik olarak ayarla
            LblTask.TextChanged += (s, e) =>
            {
                LblTask.Height = (int)(LblTask.PreferredHeight * 1.1); // Yazının boyutuna göre dinamik yükseklik
            };

            taskPanel.Height = LblTask.Height + 10; // Yüksekliği metne göre ayarla

            FlowLayoutPanel contentPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                Padding = new Padding(5),
                Margin = new Padding(3),
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false
            };

            contentPanel.Controls.Add(PBoxTaskLevel);
            contentPanel.Controls.Add(LblTask);
            taskPanel.Controls.Add(contentPanel);
            panel.Controls.Add(taskPanel);
            panel.Controls.SetChildIndex(taskPanel, 0);
            //ScrollToBottom(panel);
        }

        private void PullData()
        {
            string connectionString = "Server=localhost; Database=FPomoDB; Integrated Security=True;";
            string query = "select * from TblTasks where UserID = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", Properties.Settings.Default.SavedUserID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();  // Verileri çekiyoruz
                                                             // Verileri okuma
                while (reader.Read())
                {
                    int taskLevel = Convert.ToInt32(reader["TaskLevel"]);
                    string taskDescription = reader["Description"].ToString();
                    int taskIsCompleted = Convert.ToInt32(reader["IsCompleted"]);

                    if (taskIsCompleted == 1)
                    {
                        AddTask(FLCTasksPanel, taskDescription, taskLevel);
                    }
                }
            }
        }
    }
}
