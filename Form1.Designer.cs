namespace FPomoApp
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            panel1 = new Panel();
            BtnDown = new Button();
            BtnClose = new Button();
            panel2 = new Panel();
            BtnInfo = new Button();
            BtnSettings = new Button();
            BtnWallet = new Button();
            BtnStatics = new Button();
            BtnPomo = new Button();
            PBoxLogo = new PictureBox();
            BtnWTask = new Button();
            BtnTasks = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 31, 31);
            panel1.Controls.Add(BtnDown);
            panel1.Controls.Add(BtnClose);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.GrayText;
            panel1.Location = new Point(74, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1419, 32);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // BtnDown
            // 
            BtnDown.BackColor = Color.FromArgb(31, 31, 31);
            BtnDown.Dock = DockStyle.Right;
            BtnDown.FlatAppearance.BorderSize = 0;
            BtnDown.FlatStyle = FlatStyle.Flat;
            BtnDown.Font = new Font("Adobe Gothic Std B", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDown.ForeColor = SystemColors.WindowFrame;
            BtnDown.Location = new Point(1327, 0);
            BtnDown.Name = "BtnDown";
            BtnDown.Size = new Size(46, 32);
            BtnDown.TabIndex = 1;
            BtnDown.Text = "_";
            BtnDown.UseVisualStyleBackColor = false;
            BtnDown.Click += button1_Click;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.FromArgb(31, 31, 31);
            BtnClose.Dock = DockStyle.Right;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.ForeColor = SystemColors.WindowFrame;
            BtnClose.Location = new Point(1373, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(46, 32);
            BtnClose.TabIndex = 0;
            BtnClose.Text = "X";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(BtnInfo);
            panel2.Controls.Add(BtnSettings);
            panel2.Controls.Add(BtnWallet);
            panel2.Controls.Add(BtnStatics);
            panel2.Controls.Add(BtnPomo);
            panel2.Controls.Add(PBoxLogo);
            panel2.Controls.Add(BtnWTask);
            panel2.Controls.Add(BtnTasks);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(74, 736);
            panel2.TabIndex = 1;
            // 
            // BtnInfo
            // 
            BtnInfo.BackColor = Color.Transparent;
            BtnInfo.BackgroundImage = Properties.Resources.info1;
            BtnInfo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnInfo.Cursor = Cursors.Hand;
            BtnInfo.FlatAppearance.BorderSize = 0;
            BtnInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnInfo.FlatStyle = FlatStyle.Flat;
            BtnInfo.ForeColor = Color.Transparent;
            BtnInfo.Location = new Point(12, 593);
            BtnInfo.Name = "BtnInfo";
            BtnInfo.Size = new Size(50, 51);
            BtnInfo.TabIndex = 8;
            BtnInfo.UseVisualStyleBackColor = false;
            BtnInfo.Click += BtnInfo_Click;
            // 
            // BtnSettings
            // 
            BtnSettings.BackColor = Color.Transparent;
            BtnSettings.BackgroundImage = Properties.Resources.setting1;
            BtnSettings.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSettings.Cursor = Cursors.Hand;
            BtnSettings.FlatAppearance.BorderSize = 0;
            BtnSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnSettings.FlatStyle = FlatStyle.Flat;
            BtnSettings.ForeColor = Color.Transparent;
            BtnSettings.Location = new Point(12, 659);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(50, 51);
            BtnSettings.TabIndex = 7;
            BtnSettings.UseVisualStyleBackColor = false;
            BtnSettings.Click += BtnSettings_Click;
            // 
            // BtnWallet
            // 
            BtnWallet.BackColor = Color.Transparent;
            BtnWallet.BackgroundImage = Properties.Resources.wallet1;
            BtnWallet.BackgroundImageLayout = ImageLayout.Zoom;
            BtnWallet.Cursor = Cursors.Hand;
            BtnWallet.FlatAppearance.BorderSize = 0;
            BtnWallet.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnWallet.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnWallet.FlatStyle = FlatStyle.Flat;
            BtnWallet.ForeColor = Color.Transparent;
            BtnWallet.Location = new Point(12, 396);
            BtnWallet.Name = "BtnWallet";
            BtnWallet.Size = new Size(50, 51);
            BtnWallet.TabIndex = 6;
            BtnWallet.UseVisualStyleBackColor = false;
            BtnWallet.Click += BtnWallet_Click;
            // 
            // BtnStatics
            // 
            BtnStatics.BackColor = Color.Transparent;
            BtnStatics.BackgroundImage = (Image)resources.GetObject("BtnStatics.BackgroundImage");
            BtnStatics.BackgroundImageLayout = ImageLayout.Zoom;
            BtnStatics.Cursor = Cursors.Hand;
            BtnStatics.FlatAppearance.BorderSize = 0;
            BtnStatics.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnStatics.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnStatics.FlatStyle = FlatStyle.Flat;
            BtnStatics.ForeColor = Color.Transparent;
            BtnStatics.Location = new Point(12, 323);
            BtnStatics.Name = "BtnStatics";
            BtnStatics.Size = new Size(50, 51);
            BtnStatics.TabIndex = 5;
            BtnStatics.UseVisualStyleBackColor = false;
            BtnStatics.Click += BtnStatics_Click;
            // 
            // BtnPomo
            // 
            BtnPomo.BackColor = Color.Transparent;
            BtnPomo.BackgroundImage = (Image)resources.GetObject("BtnPomo.BackgroundImage");
            BtnPomo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPomo.Cursor = Cursors.Hand;
            BtnPomo.FlatAppearance.BorderSize = 0;
            BtnPomo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnPomo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnPomo.FlatStyle = FlatStyle.Flat;
            BtnPomo.ForeColor = Color.Transparent;
            BtnPomo.Location = new Point(12, 250);
            BtnPomo.Name = "BtnPomo";
            BtnPomo.Size = new Size(50, 51);
            BtnPomo.TabIndex = 4;
            BtnPomo.UseVisualStyleBackColor = false;
            BtnPomo.Click += BtnPomo_Click;
            // 
            // PBoxLogo
            // 
            PBoxLogo.Image = Properties.Resources.logo1;
            PBoxLogo.Location = new Point(3, 0);
            PBoxLogo.Name = "PBoxLogo";
            PBoxLogo.Size = new Size(68, 68);
            PBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxLogo.TabIndex = 2;
            PBoxLogo.TabStop = false;
            // 
            // BtnWTask
            // 
            BtnWTask.BackColor = Color.Transparent;
            BtnWTask.BackgroundImage = Properties.Resources.tasklist2;
            BtnWTask.BackgroundImageLayout = ImageLayout.Zoom;
            BtnWTask.Cursor = Cursors.Hand;
            BtnWTask.FlatAppearance.BorderSize = 0;
            BtnWTask.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnWTask.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnWTask.FlatStyle = FlatStyle.Flat;
            BtnWTask.ForeColor = Color.Transparent;
            BtnWTask.Location = new Point(12, 176);
            BtnWTask.Name = "BtnWTask";
            BtnWTask.Size = new Size(50, 51);
            BtnWTask.TabIndex = 3;
            BtnWTask.UseVisualStyleBackColor = false;
            BtnWTask.Click += BtnWTask_Click;
            // 
            // BtnTasks
            // 
            BtnTasks.BackColor = Color.Transparent;
            BtnTasks.BackgroundImage = Properties.Resources.task2;
            BtnTasks.BackgroundImageLayout = ImageLayout.Zoom;
            BtnTasks.Cursor = Cursors.Hand;
            BtnTasks.FlatAppearance.BorderSize = 0;
            BtnTasks.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnTasks.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnTasks.FlatStyle = FlatStyle.Flat;
            BtnTasks.ForeColor = Color.Transparent;
            BtnTasks.Location = new Point(12, 101);
            BtnTasks.Name = "BtnTasks";
            BtnTasks.Size = new Size(50, 51);
            BtnTasks.TabIndex = 2;
            BtnTasks.UseVisualStyleBackColor = false;
            BtnTasks.Click += BtnTasks_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(74, 32);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1419, 704);
            panelContainer.TabIndex = 2;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(1493, 736);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FPOMO";
            Load += App_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnDown;
        private Button BtnClose;
        private Panel panel2;
        private Button BtnTasks;
        private PictureBox PBoxLogo;
        private Button BtnWTask;
        private Button BtnPomo;
        private Button BtnStatics;
        private Button BtnWallet;
        private Button BtnSettings;
        private Button BtnInfo;
        private Panel panelContainer;
    }
}