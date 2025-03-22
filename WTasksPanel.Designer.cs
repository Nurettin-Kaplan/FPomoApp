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
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // LblTask
            // 
            LblTask.AutoSize = true;
            LblTask.Font = new Font("Yu Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LblTask.ForeColor = Color.White;
            LblTask.Location = new Point(45, 42);
            LblTask.Name = "LblTask";
            LblTask.Size = new Size(206, 56);
            LblTask.TabIndex = 0;
            LblTask.Text = "Görevler";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(45, 118);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(376, 543);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(989, 118);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(376, 543);
            flowLayoutPanel2.TabIndex = 11;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(517, 118);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(376, 543);
            flowLayoutPanel3.TabIndex = 11;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(LblTask);
            Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Tasks";
            Size = new Size(1419, 704);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTask;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}
