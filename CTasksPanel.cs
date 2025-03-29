using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
