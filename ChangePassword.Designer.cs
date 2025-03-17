namespace FPomoApp
{
    partial class ChangePassword
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
            groupBox5 = new GroupBox();
            PBoxViewPass2 = new PictureBox();
            TxtPassword2 = new TextBox();
            groupBox2 = new GroupBox();
            PBoxViewPass = new PictureBox();
            TxtPassword = new TextBox();
            BtnChangePass = new Button();
            LblStatus = new Label();
            BtnBack = new Button();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxViewPass2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxViewPass).BeginInit();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(PBoxViewPass2);
            groupBox5.Controls.Add(TxtPassword2);
            groupBox5.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.ForeColor = Color.DarkGray;
            groupBox5.Location = new Point(150, 333);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(308, 77);
            groupBox5.TabIndex = 10;
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
            groupBox2.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.DarkGray;
            groupBox2.Location = new Point(150, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 77);
            groupBox2.TabIndex = 9;
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
            // BtnChangePass
            // 
            BtnChangePass.BackColor = Color.Black;
            BtnChangePass.BackgroundImageLayout = ImageLayout.Zoom;
            BtnChangePass.FlatAppearance.BorderSize = 0;
            BtnChangePass.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            BtnChangePass.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnChangePass.FlatStyle = FlatStyle.Flat;
            BtnChangePass.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnChangePass.ForeColor = Color.Transparent;
            BtnChangePass.Image = Properties.Resources.changePass;
            BtnChangePass.ImageAlign = ContentAlignment.MiddleRight;
            BtnChangePass.Location = new Point(338, 439);
            BtnChangePass.Name = "BtnChangePass";
            BtnChangePass.RightToLeft = RightToLeft.Yes;
            BtnChangePass.Size = new Size(114, 52);
            BtnChangePass.TabIndex = 12;
            BtnChangePass.Text = "Değiştir";
            BtnChangePass.TextAlign = ContentAlignment.MiddleLeft;
            BtnChangePass.UseVisualStyleBackColor = false;
            BtnChangePass.Click += BtnChangePass_Click;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblStatus.ForeColor = Color.Red;
            LblStatus.Location = new Point(175, 507);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(0, 28);
            LblStatus.TabIndex = 14;
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
            BtnBack.Location = new Point(166, 439);
            BtnBack.Name = "BtnBack";
            BtnBack.RightToLeft = RightToLeft.Yes;
            BtnBack.Size = new Size(114, 52);
            BtnBack.TabIndex = 15;
            BtnBack.Text = "Geri";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(BtnBack);
            Controls.Add(LblStatus);
            Controls.Add(BtnChangePass);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ChangePassword";
            Size = new Size(608, 647);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxViewPass2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxViewPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox5;
        private PictureBox PBoxViewPass2;
        private TextBox TxtPassword2;
        private GroupBox groupBox2;
        private PictureBox PBoxViewPass;
        private TextBox TxtPassword;
        private Button BtnChangePass;
        private Label LblStatus;
        private Button BtnBack;
    }
}
