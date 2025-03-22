namespace FPomoApp
{
    partial class CTasksPanel
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
            LblHeader = new Label();
            FLCTasksPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // LblHeader
            // 
            LblHeader.AutoSize = true;
            LblHeader.Font = new Font("Yu Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LblHeader.ForeColor = Color.White;
            LblHeader.Location = new Point(47, 45);
            LblHeader.Name = "LblHeader";
            LblHeader.Size = new Size(494, 56);
            LblHeader.TabIndex = 7;
            LblHeader.Text = "Tamamlanan Görevler";
            // 
            // FLCTasksPanel
            // 
            FLCTasksPanel.Location = new Point(47, 113);
            FLCTasksPanel.Name = "FLCTasksPanel";
            FLCTasksPanel.Size = new Size(1325, 543);
            FLCTasksPanel.TabIndex = 9;
            // 
            // CTasksPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(FLCTasksPanel);
            Controls.Add(LblHeader);
            Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CTasksPanel";
            Size = new Size(1419, 704);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblHeader;
        private FlowLayoutPanel FLCTasksPanel;
    }
}
