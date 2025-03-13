namespace FPomoApp
{
    partial class Tasks
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
            LblTask = new Label();
            SuspendLayout();
            // 
            // LblTask
            // 
            LblTask.AutoSize = true;
            LblTask.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LblTask.ForeColor = Color.White;
            LblTask.Location = new Point(45, 42);
            LblTask.Name = "LblTask";
            LblTask.Size = new Size(219, 54);
            LblTask.TabIndex = 0;
            LblTask.Text = "GÖREVLER";
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(LblTask);
            Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Tasks";
            Size = new Size(1419, 704);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTask;
    }
}
