namespace lab_3
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
            txtnum = new TextBox();
            lblCalculate = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 65);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter the number:";
            // 
            // txtnum
            // 
            txtnum.Location = new Point(206, 65);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(138, 27);
            txtnum.TabIndex = 1;
            // 
            // lblCalculate
            // 
            lblCalculate.BackColor = Color.LightCoral;
            lblCalculate.Location = new Point(206, 116);
            lblCalculate.Name = "lblCalculate";
            lblCalculate.Size = new Size(138, 52);
            lblCalculate.TabIndex = 2;
            lblCalculate.Text = "Calculate";
            lblCalculate.UseVisualStyleBackColor = false;
            lblCalculate.Click += lblCalculate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 68);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Result:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(466, 72);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(456, 68);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCalculate);
            Controls.Add(txtnum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnum;
        private Button lblCalculate;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
