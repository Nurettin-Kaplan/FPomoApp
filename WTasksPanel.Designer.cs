using System.Windows.Forms;

namespace FPomoApp
{
    partial class Tasks
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblTask = new Label();
            FLEasyTasks = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            BtnAddEasy = new Button();
            pictureBox1 = new PictureBox();
            FLHardTasks = new FlowLayoutPanel();
            panel3 = new Panel();
            label3 = new Label();
            BtnAddHard = new Button();
            pictureBox3 = new PictureBox();
            FLNormalTasks = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            BtnAddNormal = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LblTask
            // 
            LblTask.AutoSize = true;
            LblTask.Font = new Font("Yu Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LblTask.ForeColor = Color.White;
            LblTask.Location = new Point(36, 14);
            LblTask.Name = "LblTask";
            LblTask.Size = new Size(206, 56);
            LblTask.TabIndex = 0;
            LblTask.Text = "Görevler";
            // 
            // FLEasyTasks
            // 
            FLEasyTasks.BackColor = Color.FromArgb(31, 31, 31);
            FLEasyTasks.FlowDirection = FlowDirection.TopDown;
            FLEasyTasks.Location = new Point(45, 124);
            FLEasyTasks.Name = "FLEasyTasks";
            FLEasyTasks.Width = 385;
            FLEasyTasks.Height = 537;
            FLEasyTasks.TabIndex = 10;
            //FLEasyTasks.AutoScroll = true;      // Kaydırma açık
            FLEasyTasks.HorizontalScroll.Maximum = 0;
            FLEasyTasks.HorizontalScroll.Visible = false;
            FLEasyTasks.HorizontalScroll.Enabled = false;
            FLEasyTasks.WrapContents = false;     // İçerikleri alta kaydır
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnAddEasy);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(45, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 35);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 5);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 3;
            label1.Text = "Sıradan";
            // 
            // BtnAddEasy
            // 
            BtnAddEasy.Dock = DockStyle.Right;
            BtnAddEasy.FlatAppearance.BorderSize = 0;
            BtnAddEasy.FlatStyle = FlatStyle.Flat;
            BtnAddEasy.Image = Properties.Resources.addTask;
            BtnAddEasy.Location = new Point(340, 0);
            BtnAddEasy.Name = "BtnAddEasy";
            BtnAddEasy.Size = new Size(36, 35);
            BtnAddEasy.TabIndex = 2;
            BtnAddEasy.UseVisualStyleBackColor = true;
            BtnAddEasy.Click += BtnAddEasy_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.greenCircle;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FLHardTasks
            // 
            FLHardTasks.BackColor = Color.FromArgb(31, 31, 31);
            FLHardTasks.FlowDirection = FlowDirection.TopDown;
            FLHardTasks.Location = new Point(989, 124);
            FLHardTasks.Name = "FLHardTasks";
            FLHardTasks.Width = 385;
            FLHardTasks.Height = 537;
            FLHardTasks.TabIndex = 11;
            //FLHardTasks.AutoScroll = true;      // Kaydırma açık
            FLHardTasks.HorizontalScroll.Maximum = 0;
            FLHardTasks.HorizontalScroll.Visible = false;
            FLHardTasks.HorizontalScroll.Enabled = false;
            FLHardTasks.WrapContents = false;     // İçerikleri alta kaydır
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(BtnAddHard);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(989, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(385, 35);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 5);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 5;
            label3.Text = "Acil";
            // 
            // BtnAddHard
            // 
            BtnAddHard.Dock = DockStyle.Right;
            BtnAddHard.FlatAppearance.BorderSize = 0;
            BtnAddHard.FlatStyle = FlatStyle.Flat;
            BtnAddHard.Image = Properties.Resources.addTask;
            BtnAddHard.Location = new Point(352, 0);
            BtnAddHard.Name = "BtnAddHard";
            BtnAddHard.Size = new Size(33, 35);
            BtnAddHard.TabIndex = 1;
            BtnAddHard.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources.redCircle;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // FLNormalTasks
            // 
            FLNormalTasks.BackColor = Color.FromArgb(31, 31, 31);
            FLNormalTasks.FlowDirection = FlowDirection.TopDown;
            FLNormalTasks.Location = new Point(526, 124);
            FLNormalTasks.Name = "FLNormalTasks";
            FLNormalTasks.Width = 385;
            FLNormalTasks.Height = 537;
            FLNormalTasks.TabIndex = 11;
            //FLNormalTasks.AutoScroll = true;      // Kaydırma açık
            FLNormalTasks.HorizontalScroll.Maximum = 0;
            FLNormalTasks.HorizontalScroll.Visible = false;
            FLNormalTasks.HorizontalScroll.Enabled = false;
            FLNormalTasks.WrapContents = false;     // İçerikleri alta kaydır
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(BtnAddNormal);
            panel2.Location = new Point(526, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 35);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 5);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 4;
            label2.Text = "Önemli";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.yellowCircle;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // BtnAddNormal
            // 
            BtnAddNormal.Dock = DockStyle.Right;
            BtnAddNormal.FlatAppearance.BorderSize = 0;
            BtnAddNormal.FlatStyle = FlatStyle.Flat;
            BtnAddNormal.Image = Properties.Resources.addTask;
            BtnAddNormal.Location = new Point(349, 0);
            BtnAddNormal.Name = "BtnAddNormal";
            BtnAddNormal.Size = new Size(36, 35);
            BtnAddNormal.TabIndex = 1;
            BtnAddNormal.UseVisualStyleBackColor = true;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(panel2);
            Controls.Add(FLNormalTasks);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(FLHardTasks);
            Controls.Add(FLEasyTasks);
            Controls.Add(LblTask);
            Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Tasks";
            Size = new Size(1419, 704);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTask;
        private FlowLayoutPanel FLEasyTasks;
        private FlowLayoutPanel FLHardTasks;
        private FlowLayoutPanel FLNormalTasks;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button BtnAddEasy;
        private Button BtnAddHard;
        private Button BtnAddNormal;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
