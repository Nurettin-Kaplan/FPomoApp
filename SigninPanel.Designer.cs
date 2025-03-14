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
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            TxtPassword = new TextBox();
            groupBox4 = new GroupBox();
            textBox3 = new TextBox();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            TxtUsername = new TextBox();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
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
            BtnBack.TabIndex = 25;
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
            BtnSignIn.TabIndex = 24;
            BtnSignIn.Text = "Kayıt Ol";
            BtnSignIn.TextAlign = ContentAlignment.MiddleLeft;
            BtnSignIn.UseVisualStyleBackColor = false;
            BtnSignIn.Click += BtnSignIn_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox1);
            groupBox5.ForeColor = Color.DarkGray;
            groupBox5.Location = new Point(150, 241);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(308, 77);
            groupBox5.TabIndex = 23;
            groupBox5.TabStop = false;
            groupBox5.Text = "    Şifre (Tekrar)    ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(31, 31, 31);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(16, 39);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '●';
            textBox1.Size = new Size(277, 18);
            textBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtPassword);
            groupBox2.ForeColor = Color.DarkGray;
            groupBox2.Location = new Point(150, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 77);
            groupBox2.TabIndex = 22;
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
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox3);
            groupBox4.ForeColor = Color.DarkGray;
            groupBox4.Location = new Point(150, 432);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(308, 77);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "    Telefon    ";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(31, 31, 31);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(16, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 27);
            textBox3.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.ForeColor = Color.DarkGray;
            groupBox3.Location = new Point(150, 337);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(308, 77);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "    E-Mail    ";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(31, 31, 31);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(16, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 27);
            textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtUsername);
            groupBox1.ForeColor = Color.DarkGray;
            groupBox1.Location = new Point(150, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 77);
            groupBox1.TabIndex = 19;
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
            TxtUsername.TabIndex = 3;
            // 
            // SigninPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
        private Button BtnSignIn;
        private GroupBox groupBox5;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox TxtPassword;
        private GroupBox groupBox4;
        private TextBox textBox3;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private TextBox TxtUsername;
    }
}
