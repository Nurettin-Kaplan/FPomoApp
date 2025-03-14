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
            TxtUsername = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            TxtPassword = new TextBox();
            PBoxUser = new PictureBox();
            BtnLogin = new Button();
            BtnSignIn = new Button();
            LinkLblForgotPass = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxLogo).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxUser).BeginInit();
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
            PBoxLogo.Image = Properties.Resources.logo1;
            PBoxLogo.Location = new Point(0, 0);
            PBoxLogo.Name = "PBoxLogo";
            PBoxLogo.Size = new Size(74, 73);
            PBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxLogo.TabIndex = 2;
            PBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(PBoxLogo);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(74, 679);
            panel2.TabIndex = 2;
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.FromArgb(31, 31, 31);
            TxtUsername.BorderStyle = BorderStyle.None;
            TxtUsername.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsername.ForeColor = Color.White;
            TxtUsername.Location = new Point(16, 30);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(277, 27);
            TxtUsername.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtUsername);
            groupBox1.ForeColor = Color.DarkGray;
            groupBox1.Location = new Point(223, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 77);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "    Kullanıcı Adı    ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtPassword);
            groupBox2.ForeColor = Color.DarkGray;
            groupBox2.Location = new Point(223, 399);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 77);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "    Şifre    ";
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.FromArgb(31, 31, 31);
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.ForeColor = Color.White;
            TxtPassword.Location = new Point(16, 39);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.Size = new Size(277, 18);
            TxtPassword.TabIndex = 3;
            // 
            // PBoxUser
            // 
            PBoxUser.Image = Properties.Resources.user;
            PBoxUser.Location = new Point(276, 47);
            PBoxUser.Name = "PBoxUser";
            PBoxUser.Size = new Size(212, 239);
            PBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxUser.TabIndex = 6;
            PBoxUser.TabStop = false;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.Black;
            BtnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            BtnLogin.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.Transparent;
            BtnLogin.Image = Properties.Resources.loginbox;
            BtnLogin.ImageAlign = ContentAlignment.MiddleRight;
            BtnLogin.Location = new Point(417, 542);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.RightToLeft = RightToLeft.Yes;
            BtnLogin.Size = new Size(114, 52);
            BtnLogin.TabIndex = 7;
            BtnLogin.Text = "Giriş Yap";
            BtnLogin.TextAlign = ContentAlignment.MiddleLeft;
            BtnLogin.UseVisualStyleBackColor = false;
            // 
            // BtnSignIn
            // 
            BtnSignIn.BackColor = Color.Black;
            BtnSignIn.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSignIn.FlatAppearance.BorderSize = 0;
            BtnSignIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            BtnSignIn.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnSignIn.FlatStyle = FlatStyle.Flat;
            BtnSignIn.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSignIn.ForeColor = Color.Transparent;
            BtnSignIn.Image = Properties.Resources.user_add_fill;
            BtnSignIn.ImageAlign = ContentAlignment.MiddleRight;
            BtnSignIn.Location = new Point(223, 542);
            BtnSignIn.Name = "BtnSignIn";
            BtnSignIn.RightToLeft = RightToLeft.Yes;
            BtnSignIn.Size = new Size(114, 52);
            BtnSignIn.TabIndex = 8;
            BtnSignIn.Text = "Kayıt Ol";
            BtnSignIn.TextAlign = ContentAlignment.MiddleLeft;
            BtnSignIn.UseVisualStyleBackColor = false;
            // 
            // LinkLblForgotPass
            // 
            LinkLblForgotPass.ActiveLinkColor = Color.White;
            LinkLblForgotPass.AutoSize = true;
            LinkLblForgotPass.LinkColor = Color.Gray;
            LinkLblForgotPass.Location = new Point(223, 490);
            LinkLblForgotPass.Name = "LinkLblForgotPass";
            LinkLblForgotPass.Size = new Size(192, 25);
            LinkLblForgotPass.TabIndex = 9;
            LinkLblForgotPass.TabStop = true;
            LinkLblForgotPass.Text = "Şifrenizi mi unuttunuz?";
            LinkLblForgotPass.VisitedLinkColor = Color.Silver;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(682, 679);
            Controls.Add(LinkLblForgotPass);
            Controls.Add(BtnSignIn);
            Controls.Add(BtnLogin);
            Controls.Add(PBoxUser);
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
            ((System.ComponentModel.ISupportInitialize)PBoxUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button BtnDown;
        private Button BtnClose;
        private PictureBox PBoxLogo;
        private Panel panel2;
        private TextBox TxtUsername;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox TxtPassword;
        private PictureBox PBoxUser;
        private Button BtnLogin;
        private Button BtnSignIn;
        private LinkLabel LinkLblForgotPass;
    }
}