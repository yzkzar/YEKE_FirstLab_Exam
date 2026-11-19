namespace YEKE_FirstLab_Exam
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SalesOutput = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.SalesOutput.AutoSize = true;
            this.SalesOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SalesOutput.Location = new System.Drawing.Point(50, 40);
            this.SalesOutput.Name = "SalesOutput";
            this.SalesOutput.Size = new System.Drawing.Size(0, 25);
            this.SalesOutput.TabIndex = 0;

            this.CloseButton.Location = new System.Drawing.Point(175, 220);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 40);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SalesOutput);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales Report";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label SalesOutput;
        private System.Windows.Forms.Button CloseButton;
    }
}
