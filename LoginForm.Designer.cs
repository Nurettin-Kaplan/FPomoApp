namespace FPomoApp
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            BtnDown = new Button();
            BtnClose = new Button();
            PBoxLogo = new PictureBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxLogo).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 31, 31);
            panel1.Controls.Add(BtnDown);
            panel1.Controls.Add(BtnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(74, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 32);
            panel1.TabIndex = 1;
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
            BtnDown.Location = new Point(516, 0);
            BtnDown.Name = "BtnDown";
            BtnDown.Size = new Size(46, 32);
            BtnDown.TabIndex = 3;
            BtnDown.Text = "_";
            BtnDown.UseVisualStyleBackColor = false;
            BtnDown.Click += BtnDown_Click;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.FromArgb(31, 31, 31);
            BtnClose.Dock = DockStyle.Right;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.ForeColor = SystemColors.WindowFrame;
            BtnClose.Location = new Point(562, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(46, 32);
            BtnClose.TabIndex = 2;
            BtnClose.Text = "X";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // PBoxLogo
            // 
            PBoxLogo.Cursor = Cursors.Hand;
            PBoxLogo.Dock = DockStyle.Top;
            PBoxLogo.Image = Properties.Resources.logo2;
            PBoxLogo.Location = new Point(0, 0);
            PBoxLogo.Name = "PBoxLogo";
            PBoxLogo.Size = new Size(74, 73);
            PBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxLogo.TabIndex = 2;
            PBoxLogo.TabStop = false;
            PBoxLogo.Click += PBoxLogo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(PBoxLogo);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(74, 650);
            panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(31, 31, 31);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(6, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.ForeColor = Color.DimGray;
            groupBox1.Location = new Point(194, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 77);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "    Kullanıcı Adı    ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.ForeColor = Color.DimGray;
            groupBox2.Location = new Point(194, 366);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 77);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "    Şifre    ";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(31, 31, 31);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(6, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 27);
            textBox2.TabIndex = 3;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(682, 650);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBoxLogo).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button BtnDown;
        private Button BtnClose;
        private PictureBox PBoxLogo;
        private Panel panel2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
    }
}