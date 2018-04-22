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

        Complex a = new Complex(0, 0, 0);
        Complex b = new Complex(0, 0, 0);
        Complex c = new Complex(0, 0, 0);

        private Complex AddComplex()
        {
            int pr = Convert.ToInt16(txtPr.Text == "" ? "0" : txtPr.Text);
            double a = Convert.ToDouble(txtA.Text == "" ? "0" : txtA.Text);
            double b = Convert.ToDouble(txtB.Text == "" ? "0" : txtB.Text);

            txtPr.Text = "";
            txtA.Text = "";
            txtB.Text = "";

            return new Complex(pr, a, b);
        }

        private void AddFirstComplex_Click(object sender, EventArgs e)
        {
            a = AddComplex();
            txtOutput.Text += "Complex Number(a) : " + a.ToString();
        }

        private void AddSecondComplex_Click(object sender, EventArgs e)
        {
            b = AddComplex();
            txtOutput.Text += "Complex Number(b) : " + b.ToString();
        }

        private void AddThirdComplex_Click(object sender, EventArgs e)
        {
            c = AddComplex();
            txtOutput.Text += "Complex Number(c) : " + c.ToString();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Complex X = ((a + b) * (c * c)) / (b - a);
            txtOutput.Text += "Complex Number(X) : " + X.ToString();

        }
    }
}
