namespace FPomoApp
{
    partial class EmailConfirmationPanel
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            LblCountdown = new Label();
            groupBox1 = new GroupBox();
            MTxtCode = new MaskedTextBox();
            BtnConfrim = new Button();
            label1 = new Label();
            LinkLblForgotMail = new LinkLabel();
            LblStatus = new Label();
            BtnBack = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // LblCountdown
            // 
            LblCountdown.AutoSize = true;
            LblCountdown.Font = new Font("Yu Gothic UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LblCountdown.ForeColor = Color.White;
            LblCountdown.Location = new Point(202, 265);
            LblCountdown.Name = "LblCountdown";
            LblCountdown.Size = new Size(0, 81);
            LblCountdown.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MTxtCode);
            groupBox1.ForeColor = Color.DarkGray;
            groupBox1.Location = new Point(141, 397);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 77);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "    Kodu Girin    ";
            // 
            // MTxtCode
            // 
            MTxtCode.BackColor = Color.FromArgb(31, 31, 31);
            MTxtCode.BorderStyle = BorderStyle.None;
            MTxtCode.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MTxtCode.ForeColor = Color.White;
            MTxtCode.Location = new Point(16, 30);
            MTxtCode.Mask = "000000";
            MTxtCode.Name = "MTxtCode";
            MTxtCode.Size = new Size(254, 27);
            MTxtCode.TabIndex = 6;
            // 
            // BtnConfrim
            // 
            BtnConfrim.BackColor = Color.Black;
            BtnConfrim.BackgroundImageLayout = ImageLayout.Zoom;
            BtnConfrim.FlatAppearance.BorderSize = 0;
            BtnConfrim.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            BtnConfrim.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnConfrim.FlatStyle = FlatStyle.Flat;
            BtnConfrim.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConfrim.ForeColor = Color.Transparent;
            BtnConfrim.Image = Properties.Resources.mail;
            BtnConfrim.ImageAlign = ContentAlignment.MiddleRight;
            BtnConfrim.Location = new Point(335, 544);
            BtnConfrim.Name = "BtnConfrim";
            BtnConfrim.RightToLeft = RightToLeft.Yes;
            BtnConfrim.Size = new Size(114, 52);
            BtnConfrim.TabIndex = 5;
            BtnConfrim.Text = "Onayla";
            BtnConfrim.TextAlign = ContentAlignment.MiddleLeft;
            BtnConfrim.UseVisualStyleBackColor = false;
            BtnConfrim.Click += BtnConfrim_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 182);
            label1.Name = "label1";
            label1.Size = new Size(576, 39);
            label1.TabIndex = 6;
            label1.Text = "Gelen kutundaki kodu yazabilir misin?";
            // 
            // LinkLblForgotMail
            // 
            LinkLblForgotMail.ActiveLinkColor = Color.White;
            LinkLblForgotMail.AutoSize = true;
            LinkLblForgotMail.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LinkLblForgotMail.LinkColor = Color.Gray;
            LinkLblForgotMail.Location = new Point(157, 498);
            LinkLblForgotMail.Margin = new Padding(4, 0, 4, 0);
            LinkLblForgotMail.Name = "LinkLblForgotMail";
            LinkLblForgotMail.Size = new Size(114, 25);
            LinkLblForgotMail.TabIndex = 8;
            LinkLblForgotMail.TabStop = true;
            LinkLblForgotMail.Text = "Kod Gelmedi";
            LinkLblForgotMail.VisitedLinkColor = Color.Silver;
            LinkLblForgotMail.LinkClicked += LinkLblForgotMail_LinkClicked;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblStatus.ForeColor = Color.Red;
            LblStatus.Location = new Point(157, 619);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(0, 28);
            LblStatus.TabIndex = 31;
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
            BtnBack.Location = new Point(141, 544);
            BtnBack.Name = "BtnBack";
            BtnBack.RightToLeft = RightToLeft.Yes;
            BtnBack.Size = new Size(114, 52);
            BtnBack.TabIndex = 32;
            BtnBack.Text = "Geri";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Visible = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // EmailConfirmationPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(BtnBack);
            Controls.Add(LblStatus);
            Controls.Add(LinkLblForgotMail);
            Controls.Add(label1);
            Controls.Add(BtnConfrim);
            Controls.Add(groupBox1);
            Controls.Add(LblCountdown);
            Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "EmailConfirmationPanel";
            Size = new Size(600, 716);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label LblCountdown;
        private GroupBox groupBox1;
        private Button BtnConfrim;
        private MaskedTextBox MTxtCode;
        private Label label1;
        private LinkLabel LinkLblForgotMail;
        private Label LblStatus;
        private Button BtnBack;
    }
}
