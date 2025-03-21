namespace FPomoApp
{
    partial class SettingsPanel
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
            BtnLogout = new Button();
            SuspendLayout();
            // 
            // BtnLogout
            // 
            BtnLogout.BackColor = Color.Black;
            BtnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLogout.FlatAppearance.BorderSize = 0;
            BtnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            BtnLogout.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnLogout.FlatStyle = FlatStyle.Flat;
            BtnLogout.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogout.ForeColor = Color.Transparent;
            BtnLogout.Image = Properties.Resources.logoutbox;
            BtnLogout.ImageAlign = ContentAlignment.MiddleRight;
            BtnLogout.Location = new Point(1187, 132);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.RightToLeft = RightToLeft.Yes;
            BtnLogout.Size = new Size(114, 52);
            BtnLogout.TabIndex = 5;
            BtnLogout.Text = "Çıkış Yap";
            BtnLogout.TextAlign = ContentAlignment.MiddleLeft;
            BtnLogout.UseVisualStyleBackColor = false;
            BtnLogout.Click += BtnLogout_Click;
            // 
            // SettingsPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(BtnLogout);
            Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SettingsPanel";
            Size = new Size(1419, 704);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnLogout;
    }
}
