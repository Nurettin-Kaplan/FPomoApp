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
            BtnConfrim = new Button();
            MTxtCode = new MaskedTextBox();
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
            LblCountdown.Location = new Point(211, 153);
            LblCountdown.Name = "LblCountdown";
            LblCountdown.Size = new Size(0, 81);
            LblCountdown.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MTxtCode);
            groupBox1.ForeColor = Color.DarkGray;
            groupBox1.Location = new Point(150, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 77);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "    Kodu Girin    ";
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
            BtnConfrim.Location = new Point(332, 402);
            BtnConfrim.Name = "BtnConfrim";
            BtnConfrim.RightToLeft = RightToLeft.Yes;
            BtnConfrim.Size = new Size(114, 52);
            BtnConfrim.TabIndex = 5;
            BtnConfrim.Text = "Onayla";
            BtnConfrim.TextAlign = ContentAlignment.MiddleLeft;
            BtnConfrim.UseVisualStyleBackColor = false;
            BtnConfrim.Click += BtnConfrim_Click;
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
            // EmailConfirmationPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(BtnConfrim);
            Controls.Add(groupBox1);
            Controls.Add(LblCountdown);
            Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "EmailConfirmationPanel";
            Size = new Size(608, 647);
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
    }
}
