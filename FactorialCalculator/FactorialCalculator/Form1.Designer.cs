namespace FactorialCalculator
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
            label1 = new Label();
            btnMax = new Button();
            textnum1 = new TextBox();
            btnPower = new Button();
            btnIsPrime = new Button();
            btnFactorıal = new Button();
            textnum2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 63);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "First Number:";
            // 
            // btnMax
            // 
            btnMax.BackColor = Color.FromArgb(252, 126, 198);
            btnMax.ForeColor = Color.Blue;
            btnMax.Location = new Point(229, 147);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(149, 65);
            btnMax.TabIndex = 1;
            btnMax.Text = "Max";
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click;
            // 
            // textnum1
            // 
            textnum1.Location = new Point(229, 60);
            textnum1.Name = "textnum1";
            textnum1.Size = new Size(149, 27);
            textnum1.TabIndex = 2;
            // 
            // btnPower
            // 
            btnPower.BackColor = Color.FromArgb(252, 126, 198);
            btnPower.ForeColor = Color.Blue;
            btnPower.Location = new Point(229, 218);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(149, 62);
            btnPower.TabIndex = 3;
            btnPower.Text = "Power";
            btnPower.UseVisualStyleBackColor = false;
            btnPower.Click += btnPower_Click;
            // 
            // btnIsPrime
            // 
            btnIsPrime.BackColor = Color.FromArgb(252, 126, 198);
            btnIsPrime.ForeColor = Color.Blue;
            btnIsPrime.Location = new Point(229, 286);
            btnIsPrime.Name = "btnIsPrime";
            btnIsPrime.Size = new Size(149, 61);
            btnIsPrime.TabIndex = 4;
            btnIsPrime.Text = "IsPrime";
            btnIsPrime.UseVisualStyleBackColor = false;
            btnIsPrime.Click += btnIsPrime_Click;
            // 
            // btnFactorıal
            // 
            btnFactorıal.BackColor = Color.FromArgb(252, 126, 198);
            btnFactorıal.ForeColor = Color.Blue;
            btnFactorıal.Location = new Point(229, 353);
            btnFactorıal.Name = "btnFactorıal";
            btnFactorıal.Size = new Size(149, 68);
            btnFactorıal.TabIndex = 5;
            btnFactorıal.Text = "Factorial";
            btnFactorıal.UseVisualStyleBackColor = false;
            btnFactorıal.Click += btnFactorıal_Click;
            // 
            // textnum2
            // 
            textnum2.Location = new Point(229, 102);
            textnum2.Name = "textnum2";
            textnum2.Size = new Size(149, 27);
            textnum2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 105);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 7;
            label2.Text = "Second Number:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 195, 230);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textnum2);
            Controls.Add(btnFactorıal);
            Controls.Add(btnIsPrime);
            Controls.Add(btnPower);
            Controls.Add(textnum1);
            Controls.Add(btnMax);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMax;
        private TextBox textnum1;
        private Button btnPower;
        private Button btnIsPrime;
        private Button btnFactorıal;
        private TextBox textnum2;
        private Label label2;
    }
}
