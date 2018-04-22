using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Point
    {
        double x, y;

        public Point()
        {
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

    }

    class Triangle
    {
        Point A, B, C;

        public Triangle()
        {
        }

        public Triangle(Point Point_A, Point Point_B, Point Point_C)
        {
            this.A = Point_A;
            this.B = Point_B;
            this.C = Point_C;
        }

        public Point Point_A
        {
            get { return A; }
            set { A = value; }
        }
        public Point Point_B
        {
            get { return B; }
            set { B = value; }
        }

        public Point Point_C
        {
            get { return C; }
            set { C = value; }
        }

        public double GetSide(Point First, Point Second)
        {
            return Math.Sqrt((Math.Pow((First.X - Second.X), 2) + Math.Pow((First.Y - Second.Y), 2)));
        }

        public bool IsTriangle()
        {
            bool result = false;
            if (
                (GetSide(this.B, this.A) + GetSide(this.B, this.C) > GetSide(this.C, this.A)) &&
                (GetSide(this.B, this.C) + GetSide(this.C, this.A) > GetSide(this.B, this.A)) &&
                (GetSide(this.B, this.A) + GetSide(this.C, this.A) > GetSide(this.B, this.C))
                )
                result = true;

            return result;
        }

        public double GetPerimeter()
        {
            return GetSide(this.B, this.A) + GetSide(this.B, this.C) + GetSide(this.C, this.A);
        }

        public double GetSquare()
        {
            double p = this.GetPerimeter() / 2;
            return Math.Sqrt(p * (p - GetSide(this.B, this.A)) * (p - GetSide(this.B, this.C)) * (p - GetSide(this.C, this.A)));
        }

        public double GetAngle(double sideA, double sideB, double sideC)
        {
            return (180 / Math.PI) * Math.Acos((sideA * sideA + sideB * sideB - sideC * sideC) / (2 * sideA * sideB));
        }

        public override String ToString()
        {
            String result;

            double SideA = GetSide(this.A, this.B);
            double SideB = GetSide(this.A, this.C);
            double SideC = GetSide(this.B, this.C);

            if (this.IsTriangle())
            {
                result = "Triangle: " + " ((" + this.A.X + "," + this.A.Y  + "), (" + this.B.X + "," + this.B.Y + "), (" + this.C.X + "," + this.C.Y + "))" + Environment.NewLine;
                result += "Perimeter: " + this.GetPerimeter() + Environment.NewLine;
                result += "Square: " + this.GetSquare() + Environment.NewLine;
                result += "Angles:" + Environment.NewLine + this.GetAngle(SideA, SideB, SideC) + Environment.NewLine;
                result += this.GetAngle(SideB, SideC, SideA) + Environment.NewLine;
                result += this.GetAngle(SideA, SideC, SideB) + Environment.NewLine;

            } else
                result = "Triangle: " + " ((" + this.A.X + "," + this.A.Y + "), (" + this.A.X + "," + this.A.Y + "), (" + this.A.X + "," + this.A.Y + "))" + " is NOT triangle" 
                    + Environment.NewLine;

            return result;
        }

    }
}
