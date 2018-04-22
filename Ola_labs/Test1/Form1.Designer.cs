namespace Test1
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
            this.txtPr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.AddSecondTime = new System.Windows.Forms.Button();
            this.AddThirdTime = new System.Windows.Forms.Button();
            this.AddFirstTime = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPr
            // 
            this.txtPr.Location = new System.Drawing.Point(75, 50);
            this.txtPr.Margin = new System.Windows.Forms.Padding(2);
            this.txtPr.Name = "txtPr";
            this.txtPr.Size = new System.Drawing.Size(150, 20);
            this.txtPr.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "The form of writing a complex number(algebraic - 1, trigonometric - 0) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(20, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "The real part of a complex number  :";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(75, 124);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(150, 20);
            this.txtA.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(20, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "The imaginary part of a complex number :";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(75, 198);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(150, 20);
            this.txtB.TabIndex = 58;
            // 
            // AddSecondTime
            // 
            this.AddSecondTime.Location = new System.Drawing.Point(400, 108);
            this.AddSecondTime.Name = "AddSecondTime";
            this.AddSecondTime.Size = new System.Drawing.Size(130, 45);
            this.AddSecondTime.TabIndex = 36;
            this.AddSecondTime.Text = "Add Second Time";
            this.AddSecondTime.UseVisualStyleBackColor = true;
            this.AddSecondTime.Click += new System.EventHandler(this.AddSecondComplex_Click);
            // 
            // AddThirdTime
            // 
            this.AddThirdTime.Location = new System.Drawing.Point(400, 173);
            this.AddThirdTime.Name = "AddThirdTime";
            this.AddThirdTime.Size = new System.Drawing.Size(130, 45);
            this.AddThirdTime.TabIndex = 37;
            this.AddThirdTime.Text = "Add Third Time";
            this.AddThirdTime.UseVisualStyleBackColor = true;
            this.AddThirdTime.Click += new System.EventHandler(this.AddThirdComplex_Click);
            // 
            // AddFirstTime
            // 
            this.AddFirstTime.Location = new System.Drawing.Point(400, 43);
            this.AddFirstTime.Name = "AddFirstTime";
            this.AddFirstTime.Size = new System.Drawing.Size(130, 45);
            this.AddFirstTime.TabIndex = 38;
            this.AddFirstTime.Text = "Add First Time";
            this.AddFirstTime.UseVisualStyleBackColor = true;
            this.AddFirstTime.Click += new System.EventHandler(this.AddFirstComplex_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(20, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "X = ((a + b) * c^2) / (b - a)";
            // 
            // txtOutput
            // 
            this.txtOutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOutput.Location = new System.Drawing.Point(25, 363);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(505, 160);
            this.txtOutput.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(20, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Output :";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(0, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(600, 2);
            this.label9.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(0, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(600, 2);
            this.label11.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(35, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "pr = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(35, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "a = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(35, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 61;
            this.label6.Text = "b = ";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(400, 258);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(130, 45);
            this.Calculate.TabIndex = 62;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 536);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddFirstTime);
            this.Controls.Add(this.AddThirdTime);
            this.Controls.Add(this.AddSecondTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPr);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button AddSecondTime;
        private System.Windows.Forms.Button AddThirdTime;
        private System.Windows.Forms.Button AddFirstTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Calculate;
    }
}

