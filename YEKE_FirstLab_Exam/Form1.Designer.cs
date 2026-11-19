namespace YEKE_FirstLab_Exam
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Initial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Submit_Click = new System.Windows.Forms.Button();
            this.Btn_Clear_Click = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Initial
            // 
            this.textBox_Initial.Location = new System.Drawing.Point(371, 92);
            this.textBox_Initial.Name = "textBox_Initial";
            this.textBox_Initial.Size = new System.Drawing.Size(186, 22);
            this.textBox_Initial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Sales Person Initial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount of Sale:";
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(370, 138);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(187, 22);
            this.textBox_Amount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "D=Danielle E=Edward F=Fatima";
            // 
            // Btn_Submit_Click
            // 
            this.Btn_Submit_Click.Location = new System.Drawing.Point(371, 197);
            this.Btn_Submit_Click.Name = "Btn_Submit_Click";
            this.Btn_Submit_Click.Size = new System.Drawing.Size(58, 41);
            this.Btn_Submit_Click.TabIndex = 5;
            this.Btn_Submit_Click.Text = "Submit";
            this.Btn_Submit_Click.UseVisualStyleBackColor = true;
            this.Btn_Submit_Click.Click += new System.EventHandler(this.Btn_Submit_Click_Click);
            // 
            // Btn_Clear_Click
            // 
            this.Btn_Clear_Click.Location = new System.Drawing.Point(435, 197);
            this.Btn_Clear_Click.Name = "Btn_Clear_Click";
            this.Btn_Clear_Click.Size = new System.Drawing.Size(58, 41);
            this.Btn_Clear_Click.TabIndex = 6;
            this.Btn_Clear_Click.Text = "Clear";
            this.Btn_Clear_Click.UseVisualStyleBackColor = true;
            this.Btn_Clear_Click.Click += new System.EventHandler(this.Btn_Clear_Click_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(499, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(203, 305);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 16);
            this.Output.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btn_Clear_Click);
            this.Controls.Add(this.Btn_Submit_Click);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Initial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Initial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Submit_Click;
        private System.Windows.Forms.Button Btn_Clear_Click;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Output;
    }
}

