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
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.AddSecondTime = new System.Windows.Forms.Button();
            this.AddThirdTime = new System.Windows.Forms.Button();
            this.AddFirstTime = new System.Windows.Forms.Button();
            this.AddFourTime = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FirstPlusSecond = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.ThirdMinusFour = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Compare = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(120, 25);
            this.txtHours.Margin = new System.Windows.Forms.Padding(2);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(50, 20);
            this.txtHours.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(45, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hours :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(185, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Minutes  :";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(260, 25);
            this.txtMinutes.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(50, 20);
            this.txtMinutes.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(325, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Seconds :";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(400, 25);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(50, 20);
            this.txtSeconds.TabIndex = 58;
            // 
            // AddSecondTime
            // 
            this.AddSecondTime.Location = new System.Drawing.Point(140, 70);
            this.AddSecondTime.Name = "AddSecondTime";
            this.AddSecondTime.Size = new System.Drawing.Size(100, 50);
            this.AddSecondTime.TabIndex = 36;
            this.AddSecondTime.Text = "Add Second Time";
            this.AddSecondTime.UseVisualStyleBackColor = true;
            this.AddSecondTime.Click += new System.EventHandler(this.AddSecondTime_Click);
            // 
            // AddThirdTime
            // 
            this.AddThirdTime.Location = new System.Drawing.Point(255, 70);
            this.AddThirdTime.Name = "AddThirdTime";
            this.AddThirdTime.Size = new System.Drawing.Size(100, 50);
            this.AddThirdTime.TabIndex = 37;
            this.AddThirdTime.Text = "Add Third Time";
            this.AddThirdTime.UseVisualStyleBackColor = true;
            this.AddThirdTime.Click += new System.EventHandler(this.AddThirdTime_Click);
            // 
            // AddFirstTime
            // 
            this.AddFirstTime.Location = new System.Drawing.Point(25, 70);
            this.AddFirstTime.Name = "AddFirstTime";
            this.AddFirstTime.Size = new System.Drawing.Size(100, 50);
            this.AddFirstTime.TabIndex = 38;
            this.AddFirstTime.Text = "Add First Time";
            this.AddFirstTime.UseVisualStyleBackColor = true;
            this.AddFirstTime.Click += new System.EventHandler(this.AddFirstTime_Click);
            // 
            // AddFourTime
            // 
            this.AddFourTime.Location = new System.Drawing.Point(370, 70);
            this.AddFourTime.Name = "AddFourTime";
            this.AddFourTime.Size = new System.Drawing.Size(100, 50);
            this.AddFourTime.TabIndex = 39;
            this.AddFourTime.Text = "Add Four Time";
            this.AddFourTime.UseVisualStyleBackColor = true;
            this.AddFourTime.Click += new System.EventHandler(this.AddFourTime_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(25, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "Five Time = First Time + Second Time";
            // 
            // FirstPlusSecond
            // 
            this.FirstPlusSecond.Location = new System.Drawing.Point(300, 150);
            this.FirstPlusSecond.Name = "FirstPlusSecond";
            this.FirstPlusSecond.Size = new System.Drawing.Size(130, 40);
            this.FirstPlusSecond.TabIndex = 47;
            this.FirstPlusSecond.Text = "Calculate";
            this.FirstPlusSecond.UseVisualStyleBackColor = true;
            this.FirstPlusSecond.Click += new System.EventHandler(this.FirstPlusSecond_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOutput.Location = new System.Drawing.Point(25, 363);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(455, 160);
            this.txtOutput.TabIndex = 48;
            // 
            // ThirdMinusFour
            // 
            this.ThirdMinusFour.Location = new System.Drawing.Point(300, 205);
            this.ThirdMinusFour.Name = "ThirdMinusFour";
            this.ThirdMinusFour.Size = new System.Drawing.Size(130, 40);
            this.ThirdMinusFour.TabIndex = 50;
            this.ThirdMinusFour.Text = "Calculate";
            this.ThirdMinusFour.UseVisualStyleBackColor = true;
            this.ThirdMinusFour.Click += new System.EventHandler(this.ThirdMinusFour_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(25, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Six Time = Third Time - Four Time";
            // 
            // Compare
            // 
            this.Compare.Location = new System.Drawing.Point(182, 275);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(130, 40);
            this.Compare.TabIndex = 52;
            this.Compare.Text = "Compare";
            this.Compare.UseVisualStyleBackColor = true;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(72, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Five Time";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(350, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 53;
            this.label6.Text = "Six Time";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(25, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Output :";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(0, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(520, 2);
            this.label9.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(0, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(520, 2);
            this.label10.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(0, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(520, 2);
            this.label11.TabIndex = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 536);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ThirdMinusFour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.FirstPlusSecond);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddFourTime);
            this.Controls.Add(this.AddFirstTime);
            this.Controls.Add(this.AddThirdTime);
            this.Controls.Add(this.AddSecondTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHours);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Button AddSecondTime;
        private System.Windows.Forms.Button AddThirdTime;
        private System.Windows.Forms.Button AddFirstTime;
        private System.Windows.Forms.Button AddFourTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button FirstPlusSecond;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button ThirdMinusFour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

