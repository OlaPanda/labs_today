using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Complex
    {
        int pr;
        double a, b;

        public Complex(int pr)
        {
            this.pr = pr;
        }

        public Complex(int pr, double a, double b)
        {
            this.pr = pr;
            this.a = a;
            this.b = b;
        }

        public int PR
        {
            get { return this.pr; }
            set { this.pr = value; }
        }

        public double A
        {
            get { return this.a; }
            set { this.a = value; }
        }
        public double B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            double new_A = c1.A + c2.A;
            double new_B = c1.B + c2.B;

            return new Complex(c1.PR, new_A, new_B);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            double new_A = c1.A - c2.A;
            double new_B = c1.B - c2.B;

            return new Complex(c1.PR, new_A, new_B);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            double new_A = (c1.A * c2.A) - (c1.B * c2.B);
            double new_B = (c1.A - c2.B) + (c1.B * c2.A);

            return new Complex(c1.PR, new_A, new_B);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            double new_A = ((c1.A * c2.A) + (c1.B * c2.B)) / (Math.Pow(c2.A, 2) + Math.Pow(c2.B, 2));
            double new_B = ((c2.A * c1.B) - (c1.A * c2.B)) / (Math.Pow(c2.A, 2) + Math.Pow(c2.B, 2));

            return new Complex(c1.PR, new_A, new_B);
        }

        public override String ToString()
        {
            String Result = "";
            if (this.pr == 1)
            {
                if (this.b < 0)
                    Result = this.a.ToString() + " - i * " + (Math.Abs(this.b)).ToString() + Environment.NewLine;
                else
                if (this.b == 0)
                    Result = this.a.ToString() + Environment.NewLine;
                else
                    Result = this.a.ToString() + " + i * " + this.b.ToString() + Environment.NewLine;
            }
            else
            {
                if (this.pr == 0)
                {
                    double r = Math.Sqrt((Math.Pow(this.a, 2) + Math.Pow(this.b, 2)));
                    double Angle = Math.Atan((this.a / this.b));

                    Result = r.ToString() + " * ( cos(" + Angle.ToString() + ") + i * sin(" + Angle.ToString() + ")" + Environment.NewLine;

                }
            }
            return Result;
        }

    }
}
