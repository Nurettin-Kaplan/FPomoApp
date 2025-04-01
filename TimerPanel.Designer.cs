namespace FPomoApp
{
    partial class TimerPanel
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
            LblHeader = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // LblHeader
            // 
            LblHeader.AutoSize = true;
            LblHeader.Font = new Font("Yu Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LblHeader.ForeColor = Color.White;
            LblHeader.Location = new Point(36, 14);
            LblHeader.Name = "LblHeader";
            LblHeader.Size = new Size(268, 56);
            LblHeader.TabIndex = 7;
            LblHeader.Text = "Odaklanma";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 185);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // TimerPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(LblHeader);
            Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TimerPanel";
            Size = new Size(1419, 704);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblHeader;
        private System.Windows.Forms.Timer timer1;
        private ErrorProvider errorProvider1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
