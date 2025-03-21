namespace FPomoApp
{
    partial class LoginPanel
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
            LinkLblForgotPass = new LinkLabel();
            BtnSignIn = new Button();
            BtnLogin = new Button();
            PBoxUser = new PictureBox();
            groupBox2 = new GroupBox();
            PBoxViewPass = new PictureBox();
            TxtPassword = new TextBox();
            groupBox1 = new GroupBox();
            TxtUsername = new TextBox();
            label1 = new Label();
            LblStatus = new Label();
            CHKRememberMe = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)PBoxUser).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxViewPass).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LinkLblForgotPass
            // 
            LinkLblForgotPass.ActiveLinkColor = Color.White;
            LinkLblForgotPass.AutoSize = true;
            LinkLblForgotPass.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LinkLblForgotPass.LinkColor = Color.Gray;
            LinkLblForgotPass.Location = new Point(306, 476);
            LinkLblForgotPass.Name = "LinkLblForgotPass";
            LinkLblForgotPass.Size = new Size(143, 25);
            LinkLblForgotPass.TabIndex = 3;
            LinkLblForgotPass.TabStop = true;
            LinkLblForgotPass.Text = "Şifremi Unuttum";
            LinkLblForgotPass.VisitedLinkColor = Color.Silver;
            LinkLblForgotPass.LinkClicked += LinkLblForgotPass_LinkClicked;
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
            BtnSignIn.Location = new Point(147, 522);
            BtnSignIn.Name = "BtnSignIn";
            BtnSignIn.RightToLeft = RightToLeft.Yes;
            BtnSignIn.Size = new Size(114, 52);
            BtnSignIn.TabIndex = 5;
            BtnSignIn.Text = "Kayıt Ol";
            BtnSignIn.TextAlign = ContentAlignment.MiddleLeft;
            BtnSignIn.UseVisualStyleBackColor = false;
            BtnSignIn.Click += BtnSignIn_Click;
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
            BtnLogin.Location = new Point(341, 522);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.RightToLeft = RightToLeft.Yes;
            BtnLogin.Size = new Size(114, 52);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Giriş Yap";
            BtnLogin.TextAlign = ContentAlignment.MiddleLeft;
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // PBoxUser
            // 
            PBoxUser.Image = Properties.Resources.user;
            PBoxUser.Location = new Point(200, 30);
            PBoxUser.Name = "PBoxUser";
            PBoxUser.Size = new Size(212, 239);
            PBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxUser.TabIndex = 12;
            PBoxUser.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PBoxViewPass);
            groupBox2.Controls.Add(TxtPassword);
            groupBox2.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.DarkGray;
            groupBox2.Location = new Point(147, 382);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 77);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "    Şifre    ";
            // 
            // PBoxViewPass
            // 
            PBoxViewPass.Cursor = Cursors.Hand;
            PBoxViewPass.Image = Properties.Resources.eyeclose;
            PBoxViewPass.Location = new Point(273, 30);
            PBoxViewPass.Name = "PBoxViewPass";
            PBoxViewPass.Size = new Size(29, 27);
            PBoxViewPass.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxViewPass.TabIndex = 16;
            PBoxViewPass.TabStop = false;
            PBoxViewPass.Click += PBoxViewPass_Click;
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.FromArgb(31, 31, 31);
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.ForeColor = Color.White;
            TxtPassword.Location = new Point(16, 30);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '•';
            TxtPassword.Size = new Size(254, 27);
            TxtPassword.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtUsername);
            groupBox1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DarkGray;
            groupBox1.Location = new Point(147, 275);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 77);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "    Kullanıcı Adı    ";
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.FromArgb(31, 31, 31);
            TxtUsername.BorderStyle = BorderStyle.None;
            TxtUsername.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsername.ForeColor = Color.White;
            TxtUsername.Location = new Point(16, 30);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(254, 27);
            TxtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(163, 592);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 24;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblStatus.ForeColor = Color.Red;
            LblStatus.Location = new Point(157, 592);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(0, 28);
            LblStatus.TabIndex = 23;
            // 
            // CHKRememberMe
            // 
            CHKRememberMe.AutoSize = true;
            CHKRememberMe.FlatAppearance.BorderSize = 0;
            CHKRememberMe.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CHKRememberMe.ForeColor = Color.Gray;
            CHKRememberMe.Location = new Point(157, 472);
            CHKRememberMe.Name = "CHKRememberMe";
            CHKRememberMe.Size = new Size(134, 32);
            CHKRememberMe.TabIndex = 25;
            CHKRememberMe.Text = "Beni Hatırla";
            CHKRememberMe.UseVisualStyleBackColor = true;
            CHKRememberMe.CheckedChanged += CHKRememberMe_CheckedChanged;
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(CHKRememberMe);
            Controls.Add(label1);
            Controls.Add(LblStatus);
            Controls.Add(LinkLblForgotPass);
            Controls.Add(BtnSignIn);
            Controls.Add(BtnLogin);
            Controls.Add(PBoxUser);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LoginPanel";
            Size = new Size(607, 646);
            Load += LoginPanel_Load;
            ((System.ComponentModel.ISupportInitialize)PBoxUser).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxViewPass).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel LinkLblForgotPass;
        private Button BtnSignIn;
        private Button BtnLogin;
        private PictureBox PBoxUser;
        private GroupBox groupBox2;
        private TextBox TxtPassword;
        private GroupBox groupBox1;
        private TextBox TxtUsername;
        private PictureBox PBoxViewPass;
        private Label label1;
        private Label LblStatus;
        private CheckBox CHKRememberMe;
    }
}
