namespace FPomoApp
{
    partial class SigninPanel
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
            BtnBack = new Button();
            BtnSignIn = new Button();
            groupBox5 = new GroupBox();
            PBoxViewPass2 = new PictureBox();
            TxtPassword2 = new TextBox();
            groupBox2 = new GroupBox();
            PBoxViewPass = new PictureBox();
            TxtPassword = new TextBox();
            groupBox4 = new GroupBox();
            MTxtPhone = new MaskedTextBox();
            groupBox3 = new GroupBox();
            TxtEmail = new TextBox();
            groupBox1 = new GroupBox();
            TxtUsername = new TextBox();
            LblStatus = new Label();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxViewPass2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxViewPass).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.Black;
            BtnBack.BackgroundImageLayout = ImageLayout.Zoom;
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            BtnBack.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBack.ForeColor = Color.Transparent;
            BtnBack.Image = Properties.Resources.back;
            BtnBack.ImageAlign = ContentAlignment.MiddleRight;
            BtnBack.Location = new Point(166, 543);
            BtnBack.Name = "BtnBack";
            BtnBack.RightToLeft = RightToLeft.Yes;
            BtnBack.Size = new Size(114, 52);
            BtnBack.TabIndex = 12;
            BtnBack.Text = "Geri";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
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
            BtnSignIn.Location = new Point(329, 543);
            BtnSignIn.Name = "BtnSignIn";
            BtnSignIn.RightToLeft = RightToLeft.Yes;
            BtnSignIn.Size = new Size(114, 52);
            BtnSignIn.TabIndex = 11;
            BtnSignIn.Text = "Kayıt Ol";
            BtnSignIn.TextAlign = ContentAlignment.MiddleLeft;
            BtnSignIn.UseVisualStyleBackColor = false;
            BtnSignIn.Click += BtnSignIn_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(PBoxViewPass2);
            groupBox5.Controls.Add(TxtPassword2);
            groupBox5.ForeColor = Color.DarkGray;
            groupBox5.Location = new Point(150, 241);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(308, 77);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "    Şifre (Tekrar)    ";
            // 
            // PBoxViewPass2
            // 
            PBoxViewPass2.Cursor = Cursors.Hand;
            PBoxViewPass2.Image = Properties.Resources.eyeclose;
            PBoxViewPass2.Location = new Point(273, 30);
            PBoxViewPass2.Name = "PBoxViewPass2";
            PBoxViewPass2.Size = new Size(29, 27);
            PBoxViewPass2.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxViewPass2.TabIndex = 18;
            PBoxViewPass2.TabStop = false;
            PBoxViewPass2.Click += PBoxViewPass2_Click;
            // 
            // TxtPassword2
            // 
            TxtPassword2.BackColor = Color.FromArgb(31, 31, 31);
            TxtPassword2.BorderStyle = BorderStyle.None;
            TxtPassword2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword2.ForeColor = Color.White;
            TxtPassword2.Location = new Point(16, 30);
            TxtPassword2.Name = "TxtPassword2";
            TxtPassword2.PasswordChar = '•';
            TxtPassword2.Size = new Size(258, 27);
            TxtPassword2.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PBoxViewPass);
            groupBox2.Controls.Add(TxtPassword);
            groupBox2.ForeColor = Color.DarkGray;
            groupBox2.Location = new Point(150, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 77);
            groupBox2.TabIndex = 7;
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
            PBoxViewPass.TabIndex = 17;
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
            TxtPassword.Size = new Size(258, 27);
            TxtPassword.TabIndex = 7;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(MTxtPhone);
            groupBox4.ForeColor = Color.DarkGray;
            groupBox4.Location = new Point(150, 432);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(308, 77);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "    Telefon    ";
            // 
            // MTxtPhone
            // 
            MTxtPhone.BackColor = Color.FromArgb(31, 31, 31);
            MTxtPhone.BorderStyle = BorderStyle.None;
            MTxtPhone.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MTxtPhone.ForeColor = Color.White;
            MTxtPhone.Location = new Point(16, 30);
            MTxtPhone.Mask = "0000000000";
            MTxtPhone.Name = "MTxtPhone";
            MTxtPhone.Size = new Size(258, 27);
            MTxtPhone.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TxtEmail);
            groupBox3.ForeColor = Color.DarkGray;
            groupBox3.Location = new Point(150, 337);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(308, 77);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "    E-Mail    ";
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = Color.FromArgb(31, 31, 31);
            TxtEmail.BorderStyle = BorderStyle.None;
            TxtEmail.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.ForeColor = Color.White;
            TxtEmail.Location = new Point(16, 30);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(277, 27);
            TxtEmail.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtUsername);
            groupBox1.ForeColor = Color.DarkGray;
            groupBox1.Location = new Point(150, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 77);
            groupBox1.TabIndex = 6;
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
            TxtUsername.Size = new Size(277, 27);
            TxtUsername.TabIndex = 6;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblStatus.ForeColor = Color.Red;
            LblStatus.Location = new Point(176, 609);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(0, 28);
            LblStatus.TabIndex = 13;
            // 
            // SigninPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(LblStatus);
            Controls.Add(BtnBack);
            Controls.Add(BtnSignIn);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "SigninPanel";
            Size = new Size(608, 647);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxViewPass2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxViewPass).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBack;
        private Button BtnSignIn;
        private GroupBox groupBox5;
        private TextBox TxtPassword2;
        private GroupBox groupBox2;
        private TextBox TxtPassword;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox TxtEmail;
        private GroupBox groupBox1;
        private TextBox TxtUsername;
        private PictureBox PBoxViewPass2;
        private PictureBox PBoxViewPass;
        private MaskedTextBox MTxtPhone;
        private Label LblStatus;
    }
}
