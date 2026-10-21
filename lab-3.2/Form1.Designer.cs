namespace lab_3._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNum = new TextBox();
            btnSumDigits = new Button();
            btnCountEven = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Location = new Point(171, 45);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(125, 27);
            txtNum.TabIndex = 0;
            // 
            // btnSumDigits
            // 
            btnSumDigits.BackColor = SystemColors.GradientActiveCaption;
            btnSumDigits.Location = new Point(171, 92);
            btnSumDigits.Name = "btnSumDigits";
            btnSumDigits.Size = new Size(125, 66);
            btnSumDigits.TabIndex = 1;
            btnSumDigits.Text = "Sum Of Digits";
            btnSumDigits.UseVisualStyleBackColor = false;
            btnSumDigits.Click += btnSumDigits_Click;
            // 
            // btnCountEven
            // 
            btnCountEven.BackColor = SystemColors.GradientActiveCaption;
            btnCountEven.Location = new Point(174, 164);
            btnCountEven.Name = "btnCountEven";
            btnCountEven.Size = new Size(122, 61);
            btnCountEven.TabIndex = 2;
            btnCountEven.Text = "Count Even Digits";
            btnCountEven.UseVisualStyleBackColor = false;
            btnCountEven.Click += btnCountEven_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 48);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter the number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 53);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Result:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(463, 54);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnCountEven);
            Controls.Add(btnSumDigits);
            Controls.Add(txtNum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private Button btnSumDigits;
        private Button btnCountEven;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
