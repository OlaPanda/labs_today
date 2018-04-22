using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {

        Time t1 = new Time(0, 0, 0);
        Time t2 = new Time(0, 0, 0);
        Time t3 = new Time(0, 0, 0);
        Time t4 = new Time(0, 0, 0);
        Time T1 = new Time(0, 0, 0);
        Time T2 = new Time(0, 0, 0);

        private Time AddTime()
        {
            int Hours = Convert.ToInt16(txtHours.Text == "" ? "0" : txtHours.Text);
            int Minutes = Convert.ToInt16(txtMinutes.Text == "" ? "0" : txtMinutes.Text);
            int Seconds = Convert.ToInt16(txtSeconds.Text == "" ? "0" : txtSeconds.Text);

            if ((Hours < 0) || (Hours >= 24))
            {
                txtOutput.Text += "Wrong time format" + Environment.NewLine;
                return new Time(0, 0, 0);
            }

            if ((Minutes < 0) || (Minutes >= 60))
            {
                txtOutput.Text += "Wrong time format" + Environment.NewLine;
                return new Time(0, 0, 0);
            }

            if ((Seconds < 0) || (Seconds >= 60))
            {
                txtOutput.Text += "Wrong time format" + Environment.NewLine;
                return new Time(0, 0, 0);
            }

            txtHours.Text = "";
            txtMinutes.Text = "";
            txtSeconds.Text = "";

            return new Time(Hours, Minutes, Seconds);
        }

        private void AddSecondTime_Click(object sender, EventArgs e)
        {
            t2 = AddTime();
            txtOutput.Text += "Second Time : " + t2.ToString();
        }

        private void AddThirdTime_Click(object sender, EventArgs e)
        {
            t3 = AddTime();
            txtOutput.Text += "Third Time : " + t3.ToString();
        }

        private void AddFourTime_Click(object sender, EventArgs e)
        {
            t4 = AddTime();
            txtOutput.Text += "Four Time : " + t4.ToString();
        }

        private void AddFirstTime_Click(object sender, EventArgs e)
        {
            t1 = AddTime();
            txtOutput.Text += "First Time : " + t1.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void FirstPlusSecond_Click(object sender, EventArgs e)
        {
            T1 = t1 + t2;
            txtOutput.Text += "Five Time : " + T1.ToString();
        }

        private void ThirdMinusFour_Click(object sender, EventArgs e)
        {
            T2 = t3 - t4;
            txtOutput.Text += "Six Time : " + T2.ToString();
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            if (T1 > T2)
                txtOutput.Text += "Five Time > Six Time" + Environment.NewLine;
            else
            if(T1 < T2)
                txtOutput.Text += "Five Time < Six Time" + Environment.NewLine;
            else
                txtOutput.Text += "Five Time == Six Time" + Environment.NewLine;
        }

    }
}
