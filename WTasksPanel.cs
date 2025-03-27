using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPomoApp
{
    public partial class Tasks : UserControl
    {
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
                    AddTask(panel, TxtWrite.Text, taskLevel);
                    panel.Controls.Remove(writePanel);
                }
            };

            writePanel.Controls.Add(TxtWrite);
            panel.Controls.Add(writePanel);
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
                AutoSize = true,
                MaximumSize = new Size(panel.Width - 50, 0),
                Padding = new Padding(5),
                Font = new Font("Yu Gothic", 12F, FontStyle.Bold),
                ForeColor = Color.White,
            };

            // Yüksekliği dinamik olarak ayarla
            LblTask.SizeChanged += (s, e) =>
            {
                taskPanel.Height = LblTask.Height + 20; // Yüksekliği metne göre ayarla
            };

            PBoxCheck.Click += async (s, e) =>
            {
                if (PBoxCheck.Tag == "checkboxBlank")
                {
                    PBoxCheck.Image = Properties.Resources.checkbox;
                    PBoxCheck.Tag = "checkbox";
                    LblTask.Font = new Font(LblTask.Font, FontStyle.Strikeout);
                    await Task.Delay(2000); // 2 saniye bekle
                    if (PBoxCheck.Tag == "checkbox")
                    {
                        // veritabanına işaretleme sonrasında writePanel'in silinme işlemi yapılacak
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

            FlowLayoutPanel contentPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true
            };

            contentPanel.Controls.Add(PBoxCheck);
            contentPanel.Controls.Add(LblTask);
            taskPanel.Controls.Add(contentPanel);
            panel.Controls.Add(taskPanel);
            ScrollToBottom(panel);
        }

        private void BtnAddEasy_Click(object sender, EventArgs e)
        {

        }

        private void ScrollToBottom(FlowLayoutPanel panel)
        {
            panel.AutoScroll = true;
            panel.VerticalScroll.Value = panel.VerticalScroll.Maximum; // En alta kaydır
        }
    }
}
