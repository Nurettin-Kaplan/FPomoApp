namespace FPomoApp
{
    partial class RefPasswordPanel
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
            LblStatus = new Label();
            BtnBack = new Button();
            BtnVerify = new Button();
            groupBox4 = new GroupBox();
            MTxtPhone = new MaskedTextBox();
            groupBox3 = new GroupBox();
            TxtEmail = new TextBox();
            groupBox1 = new GroupBox();
            TxtUsername = new TextBox();
            label1 = new Label();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblStatus.ForeColor = Color.Red;
            LblStatus.Location = new Point(176, 488);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(0, 28);
            LblStatus.TabIndex = 21;
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
            BtnBack.Location = new Point(166, 422);
            BtnBack.Name = "BtnBack";
            BtnBack.RightToLeft = RightToLeft.Yes;
            BtnBack.Size = new Size(114, 52);
            BtnBack.TabIndex = 20;
            BtnBack.Text = "Geri";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnVerify
            // 
            BtnVerify.BackColor = Color.Black;
            BtnVerify.BackgroundImageLayout = ImageLayout.Zoom;
            BtnVerify.FlatAppearance.BorderSize = 0;
            BtnVerify.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            BtnVerify.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnVerify.FlatStyle = FlatStyle.Flat;
            BtnVerify.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVerify.ForeColor = Color.Transparent;
            BtnVerify.Image = Properties.Resources.accountBox;
            BtnVerify.ImageAlign = ContentAlignment.MiddleRight;
            BtnVerify.Location = new Point(329, 422);
            BtnVerify.Name = "BtnVerify";
            BtnVerify.RightToLeft = RightToLeft.Yes;
            BtnVerify.Size = new Size(114, 52);
            BtnVerify.TabIndex = 19;
            BtnVerify.Text = "Doğrula";
            BtnVerify.TextAlign = ContentAlignment.MiddleLeft;
            BtnVerify.UseVisualStyleBackColor = false;
            BtnVerify.Click += BtnVerify_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(MTxtPhone);
            groupBox4.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.DarkGray;
            groupBox4.Location = new Point(150, 312);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(308, 77);
            groupBox4.TabIndex = 18;
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
            groupBox3.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.DarkGray;
            groupBox3.Location = new Point(150, 217);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(308, 77);
            groupBox3.TabIndex = 17;
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
            groupBox1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DarkGray;
            groupBox1.Location = new Point(150, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 77);
            groupBox1.TabIndex = 14;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(182, 488);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 22;
            // 
            // RefPasswordPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(label1);
            Controls.Add(LblStatus);
            Controls.Add(BtnBack);
            Controls.Add(BtnVerify);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "RefPasswordPanel";
            Size = new Size(608, 647);
            Load += RefPasswordPanel_Load;
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

        private Label LblStatus;
        private Button BtnBack;
        private Button BtnVerify;
        private GroupBox groupBox4;
        private MaskedTextBox MTxtPhone;
        private GroupBox groupBox3;
        private TextBox TxtEmail;
        private GroupBox groupBox1;
        private TextBox TxtUsername;
        private Label label1;
    }
}
