namespace lab_3._3
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
            txtScore = new TextBox();
            btnCheckPass = new Button();
            btnLetterGrade = new Button();
            btnAverage = new Button();
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.Location = new Point(166, 49);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(125, 27);
            txtScore.TabIndex = 0;
            // 
            // btnCheckPass
            // 
            btnCheckPass.BackColor = SystemColors.ActiveCaption;
            btnCheckPass.Location = new Point(166, 94);
            btnCheckPass.Name = "btnCheckPass";
            btnCheckPass.Size = new Size(126, 63);
            btnCheckPass.TabIndex = 1;
            btnCheckPass.Text = "Pass or Fall";
            btnCheckPass.UseVisualStyleBackColor = false;
            btnCheckPass.Click += btnCheckPass_Click;
            // 
            // btnLetterGrade
            // 
            btnLetterGrade.BackColor = SystemColors.ActiveCaption;
            btnLetterGrade.Location = new Point(166, 175);
            btnLetterGrade.Name = "btnLetterGrade";
            btnLetterGrade.Size = new Size(126, 65);
            btnLetterGrade.TabIndex = 2;
            btnLetterGrade.Text = "Letter Grade";
            btnLetterGrade.UseVisualStyleBackColor = false;
            btnLetterGrade.Click += btnLetterGrade_Click;
            // 
            // btnAverage
            // 
            btnAverage.BackColor = SystemColors.ActiveCaption;
            btnAverage.Location = new Point(166, 261);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(126, 63);
            btnAverage.TabIndex = 3;
            btnAverage.Text = "Average to 100";
            btnAverage.UseVisualStyleBackColor = false;
            btnAverage.Click += btnAverage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 56);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 4;
            label1.Text = "Enter a score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 53);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 5;
            label2.Text = "Result:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = SystemColors.ActiveCaption;
            lblResult.Location = new Point(438, 53);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAverage);
            Controls.Add(btnLetterGrade);
            Controls.Add(btnCheckPass);
            Controls.Add(txtScore);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtScore;
        private Button btnCheckPass;
        private Button btnLetterGrade;
        private Button btnAverage;
        private Label label1;
        private Label label2;
        private Label lblResult;
    }
}
