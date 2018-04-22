using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Isosceles : Triangle
    {

        public Isosceles(Point A, Point B, Point C) : base(A, B, C) { }

        public bool IsIsosceles()
        {
            
            if (
                (GetSide(this.Point_A, this.Point_B) == GetSide(this.Point_A, this.Point_C)) &&
                (GetSide(this.Point_C, this.Point_B) == GetSide(this.Point_A, this.Point_C)) &&
                (GetSide(this.Point_C, this.Point_B) == GetSide(this.Point_A, this.Point_B))
                )
                return true;

            return false;
        }


        public override String ToString()
        {
            String result;

            double SideA = GetSide(this.Point_A, this.Point_B);
            double SideB = GetSide(this.Point_A, this.Point_C);
            double SideC = GetSide(this.Point_B, this.Point_C);

            if (this.IsTriangle() && this.IsIsosceles())
            {
                result = "Isosceles triangle: " + " ((" + this.Point_A.X + "," + this.Point_A.Y + "), (" + 
                    this.Point_B.X + "," + this.Point_B.Y + "), (" + this.Point_C.X + "," + this.Point_C.Y + "))" + Environment.NewLine;
                result += "Perimeter: " + this.GetPerimeter() + Environment.NewLine;
                result += "Square: " + this.GetSquare() + Environment.NewLine;
                result += "Angles:" + Environment.NewLine + this.GetAngle(SideA, SideB, SideC) + Environment.NewLine;
                result += this.GetAngle(SideB, SideC, SideA) + Environment.NewLine;
                result += this.GetAngle(SideA, SideC, SideB) + Environment.NewLine;

            }
            else
            if (!this.IsTriangle())
                result = "Isosceles triangle: " + " ((" + this.Point_A.X + "," + this.Point_A.Y + "), (" +
                    this.Point_B.X + "," + this.Point_B.Y + "), (" + this.Point_C.X + "," + this.Point_C.Y + "))" + " is NOT triangle" + Environment.NewLine;
            else
                result = "Isosceles triangle: " + " ((" + this.Point_A.X + "," + this.Point_A.Y + "), (" +
                    this.Point_B.X + "," + this.Point_B.Y + "), (" + this.Point_C.X + "," + this.Point_C.Y + "))" + " is NOT Isosceles triangle" + Environment.NewLine;

            return result;
        }
    }
}
