using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FPomoApp
{
    public partial class Tasks : UserControl
    {
        private string connectionString = "Server=localhost; Database=FPomoDB; Integrated Security=True;";

        public Tasks()
        {
            InitializeComponent();
            BtnAddHard.Click += (s, e) => AddTaskInput(FLHardTasks, 3);
            BtnAddNormal.Click += (s, e) => AddTaskInput(FLNormalTasks, 2);
            BtnAddEasy.Click += (s, e) => AddTaskInput(FLEasyTasks, 1);
        }

        private void AddTaskInput(FlowLayoutPanel panel, int taskLevel)
        {
            Panel writePanel = new Panel
            {
                BackColor = Color.FromArgb(25, 25, 25),
                Width = panel.Width - 20,
                Height = 50, // Başlangıç yüksekliği
                Padding = new Padding(5),
                Margin = new Padding(3),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            // RTxtWrite
            TextBox TxtWrite = new TextBox
            {
                BackColor = Color.FromArgb(25, 25, 25),
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Yu Gothic", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                Multiline = true,
                WordWrap = true,
                AcceptsReturn = true,
                Width = writePanel.Width - 10, // Panel genişliğine uyumlu
                Height = 40 // Başlangıç yüksekliği
            };

            TxtWrite.TextChanged += TxtWrite_TextChanged;

            TxtWrite.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(TxtWrite.Text))
                {
                    e.SuppressKeyPress = true;

                    string query = "insert into TblTasks (TaskLevel, Description, IsCompleted, UserID) values (@level, @description, @isCompleted, @taskuid) ";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@level", taskLevel);
                        cmd.Parameters.AddWithValue("@description", TxtWrite.Text);
                        cmd.Parameters.AddWithValue("@isCompleted", 0);
                        cmd.Parameters.AddWithValue("@taskuid", Properties.Settings.Default.SavedUserID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    AddTask(panel, TxtWrite.Text, taskLevel);
                    panel.Controls.Remove(writePanel);
                }
            };

            writePanel.Controls.Add(TxtWrite);
            panel.Controls.Add(writePanel);
            panel.Controls.SetChildIndex(writePanel, 0);
            TxtWrite.Focus();
        }

        private void TxtWrite_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            Size textSize = TextRenderer.MeasureText(tb.Text, tb.Font, new Size(tb.Width, int.MaxValue), TextFormatFlags.WordBreak);
            tb.Height = Math.Max(30, textSize.Height + 10); // Minimum 30px, içeriğe göre büyür
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

            PictureBox PBoxCheck = new PictureBox
            {
                Image = Properties.Resources.checkboxBlank,
                Size = new Size(30, 30),
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Hand,
                Dock = DockStyle.Left,
                Tag = "checkboxBlank"
            };

            Label LblTask = new Label
            {
                Text = taskName,
                AutoSize = true, // AutoSize false yapılıyor
                Width = panel.Width - 50, // Sabit genişlik
                MaximumSize = new Size(panel.Width - 50, 0), // Panel genişliğine uyumlu
                Padding = new Padding(5),
                Font = new Font("Yu Gothic", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.TopLeft,
                //Height = 30 // Başlangıç yüksekliği
            };

            // Yüksekliği metnin uzunluğuna göre otomatik olarak ayarla
            LblTask.TextChanged += (s, e) =>
            {
                LblTask.Height = (int)(LblTask.PreferredHeight * 1.1); // Yazının boyutuna göre dinamik yükseklik
            };

            PBoxCheck.Click += async (s, e) =>
            {
                if (PBoxCheck.Tag == "checkboxBlank")
                {
                    PBoxCheck.Image = Properties.Resources.checkbox;
                    PBoxCheck.Tag = "checkbox";
                    LblTask.Font = new Font(LblTask.Font, FontStyle.Bold | FontStyle.Strikeout);
                    await Task.Delay(2000); // 2 saniye bekle
                    if (PBoxCheck.Tag == "checkbox")
                    {
                        string query = "update TblTasks set IsCompleted = 1 where UserID = @id";

                        using (SqlConnection con = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", Properties.Settings.Default.SavedUserID);

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                        panel.Controls.Remove(taskPanel);
                    }
                }
                else
                {
                    PBoxCheck.Image = Properties.Resources.checkboxBlank;
                    PBoxCheck.Tag = "checkboxBlank";
                    LblTask.Font = new Font(LblTask.Font, FontStyle.Regular);
                }
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

            contentPanel.Controls.Add(PBoxCheck);
            contentPanel.Controls.Add(LblTask);
            taskPanel.Controls.Add(contentPanel);
            panel.Controls.Add(taskPanel);
            panel.Controls.SetChildIndex(taskPanel, 0);
            ScrollToBottom(panel);
        }

        private void BtnAddEasy_Click(object sender, EventArgs e)
        {
            //
        }

        private void ScrollToBottom(FlowLayoutPanel panel)
        {
            panel.AutoScroll = true;
            panel.VerticalScroll.Value = panel.VerticalScroll.Maximum; // En alta kaydır
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            PullData();
        }

        private void PullData()
        {
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

                    if (taskIsCompleted == 0)
                    {
                        switch (taskLevel)
                        {
                            case 1:
                                AddTask(FLEasyTasks, taskDescription, taskLevel);
                                break;
                            case 2:
                                AddTask(FLNormalTasks, taskDescription, taskLevel);
                                break;
                            case 3:
                                AddTask(FLHardTasks, taskDescription, taskLevel);
                                break;
                        }
                    }
                }
            }
        }
    }
}
