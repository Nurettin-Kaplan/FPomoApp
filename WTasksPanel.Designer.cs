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
            BtnAddEasy = new Button();
            pictureBox1 = new PictureBox();
            FLHardTasks = new FlowLayoutPanel();
            panel3 = new Panel();
            BtnAddHard = new Button();
            pictureBox3 = new PictureBox();
            FLNormalTasks = new FlowLayoutPanel();
            panel2 = new Panel();
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
            FLEasyTasks.AutoScroll = true;
            FLEasyTasks.BackColor = Color.FromArgb(31, 31, 31);
            FLEasyTasks.FlowDirection = FlowDirection.TopDown;
            FLEasyTasks.Location = new Point(45, 124);
            FLEasyTasks.Name = "FLEasyTasks";
            FLEasyTasks.Size = new Size(385, 537);
            FLEasyTasks.TabIndex = 10;
            FLEasyTasks.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnAddEasy);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(45, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 35);
            panel1.TabIndex = 0;
            // 
            // BtnAddEasy
            // 
            BtnAddEasy.Dock = DockStyle.Right;
            BtnAddEasy.FlatAppearance.BorderSize = 0;
            BtnAddEasy.FlatStyle = FlatStyle.Flat;
            BtnAddEasy.Image = Properties.Resources.addTask;
            BtnAddEasy.Location = new Point(335, 0);
            BtnAddEasy.Name = "BtnAddEasy";
            BtnAddEasy.Size = new Size(41, 35);
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
            FLHardTasks.AutoScroll = true;
            FLHardTasks.BackColor = Color.FromArgb(31, 31, 31);
            FLHardTasks.FlowDirection = FlowDirection.TopDown;
            FLHardTasks.Location = new Point(989, 124);
            FLHardTasks.Name = "FLHardTasks";
            FLHardTasks.Size = new Size(376, 537);
            FLHardTasks.TabIndex = 11;
            FLHardTasks.WrapContents = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(BtnAddHard);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(989, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(376, 35);
            panel3.TabIndex = 1;
            // 
            // BtnAddHard
            // 
            BtnAddHard.Dock = DockStyle.Right;
            BtnAddHard.FlatAppearance.BorderSize = 0;
            BtnAddHard.FlatStyle = FlatStyle.Flat;
            BtnAddHard.Image = Properties.Resources.addTask;
            BtnAddHard.Location = new Point(329, 0);
            BtnAddHard.Name = "BtnAddHard";
            BtnAddHard.Size = new Size(47, 35);
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
            FLNormalTasks.AutoScroll = true;
            FLNormalTasks.BackColor = Color.FromArgb(31, 31, 31);
            FLNormalTasks.FlowDirection = FlowDirection.TopDown;
            FLNormalTasks.Location = new Point(517, 124);
            FLNormalTasks.Name = "FLNormalTasks";
            FLNormalTasks.Size = new Size(376, 537);
            FLNormalTasks.TabIndex = 11;
            FLNormalTasks.WrapContents = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(BtnAddNormal);
            panel2.Location = new Point(517, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 35);
            panel2.TabIndex = 0;
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
            BtnAddNormal.Location = new Point(331, 0);
            BtnAddNormal.Name = "BtnAddNormal";
            BtnAddNormal.Size = new Size(45, 35);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
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
    }
}
