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
        List<Triangle> m_triangles = new List<Triangle> { };
        List<Isosceles> m_isosceles = new List<Isosceles> { };


        public Form1()
        {
            InitializeComponent();
        }

        private void AddTriangle_Click(object sender, EventArgs e)
        {
            Point point_A;
            double X = Convert.ToDouble(txtFirstCoord_X.Text == "" ? "0" : txtFirstCoord_X.Text);
            double Y = Convert.ToDouble(txtFirstCoord_Y.Text == "" ? "0" : txtFirstCoord_Y.Text);
            point_A = new Point(X, Y);

            Point point_B;
            X = Convert.ToDouble(txtSecondCoord_X.Text == "" ? "0" : txtSecondCoord_X.Text);
            Y = Convert.ToDouble(txtSecondCoord_Y.Text == "" ? "0" : txtSecondCoord_Y.Text);
            point_B = new Point(X, Y);

            Point point_C;
            X = Convert.ToDouble(txtThirdCoord_X.Text == "" ? "0" : txtThirdCoord_X.Text);
            Y = Convert.ToDouble(txtThirdCoord_Y.Text == "" ? "0" : txtThirdCoord_Y.Text);
            point_C = new Point(X, Y);

            m_triangles.Add(new Triangle(point_A, point_B, point_C));

            txtFirstCoord_X.Text = "";
            txtFirstCoord_Y.Text = "";
            txtSecondCoord_X.Text = "";
            txtSecondCoord_Y.Text = "";
            txtThirdCoord_X.Text = "";
            txtThirdCoord_Y.Text = "";
        }

        private void DisplayTriangles_Click(object sender, EventArgs e)
        {
            OutputTriangles.Text = "";

            String Result = "";
            for (int i = 0; i < m_triangles.Count; ++i)
                Result += m_triangles[i].ToString() + Environment.NewLine;

            OutputTriangles.Text = Result;
        }

        private void AddIsosceles_Click(object sender, EventArgs e)
        {
            Point point_A;
            double X = Convert.ToDouble(txtIsoscelesFirstCoord_X.Text == "" ? "0" : txtIsoscelesFirstCoord_X.Text);
            double Y = Convert.ToDouble(txtIsoscelesFirstCoord_Y.Text == "" ? "0" : txtIsoscelesFirstCoord_Y.Text);
            point_A = new Point(X, Y);

            Point point_B;
            X = Convert.ToDouble(txtIsoscelesSecondCoord_X.Text == "" ? "0" : txtIsoscelesSecondCoord_X.Text);
            Y = Convert.ToDouble(txtIsoscelesSecondCoord_Y.Text == "" ? "0" : txtIsoscelesSecondCoord_Y.Text);
            point_B = new Point(X, Y);

            Point point_C;
            X = Convert.ToDouble(txtIsoscelesThirdCoord_X.Text == "" ? "0" : txtIsoscelesThirdCoord_X.Text);
            Y = Convert.ToDouble(txtIsoscelesThirdCoord_Y.Text == "" ? "0" : txtIsoscelesThirdCoord_Y.Text);
            point_C = new Point(X, Y);

            m_isosceles.Add(new Isosceles(point_A, point_B, point_C));

            txtIsoscelesFirstCoord_X.Text = "";
            txtIsoscelesFirstCoord_Y.Text = "";
            txtIsoscelesSecondCoord_X.Text = "";
            txtIsoscelesSecondCoord_Y.Text = "";
            txtIsoscelesThirdCoord_X.Text = "";
            txtIsoscelesThirdCoord_Y.Text = "";
        }

        private void DisplayIsosceles_Click(object sender, EventArgs e)
        {
            OutputIsosceles.Text = "";

            String Result = "";
            for (int i = 0; i < m_isosceles.Count; ++i)
                Result += m_isosceles[i].ToString() + Environment.NewLine;

            OutputIsosceles.Text = Result;
        }

        private void TriangleSimilar_Click(object sender, EventArgs e)
        {
            List<List<int>> indexs = new List<List<int>> { };

            for (int i = 0; i < m_triangles.Count; ++i)
            {
                List<int> Buffer_index = new List<int> { };

                if (m_triangles[i].IsTriangle())
                {
                    double AB = m_triangles[i].GetSide(m_triangles[i].Point_A, m_triangles[i].Point_B);
                    double BC = m_triangles[i].GetSide(m_triangles[i].Point_B, m_triangles[i].Point_C);
                    double CA = m_triangles[i].GetSide(m_triangles[i].Point_C, m_triangles[i].Point_A);

                    double Angle1 = m_triangles[i].GetAngle(AB, BC, CA);
                    double Angle2 = m_triangles[i].GetAngle(BC, CA, AB);
                    double Angle3 = m_triangles[i].GetAngle(AB, CA, BC);

                    Buffer_index.Add(i);

                    for (int y = i + 1; y < m_triangles.Count; ++y)
                    {
                        if (m_triangles[y].IsTriangle())
                        {
                            double AB_buf = m_triangles[y].GetSide(m_triangles[y].Point_A, m_triangles[y].Point_B);
                            double BC_buf = m_triangles[y].GetSide(m_triangles[y].Point_B, m_triangles[y].Point_C);
                            double CA_buf = m_triangles[y].GetSide(m_triangles[y].Point_C, m_triangles[y].Point_A);

                            double Angle1_buf = m_triangles[y].GetAngle(AB_buf, BC_buf, CA_buf);
                            double Angle2_buf = m_triangles[y].GetAngle(BC_buf, CA_buf, AB_buf);
                            double Angle3_buf = m_triangles[y].GetAngle(AB_buf, CA_buf, BC_buf);

                            if (Angle1 == Angle1_buf)
                            {
                                if (Angle2 == Angle2_buf)
                                {
                                    if (Angle3 == Angle3_buf)
                                        Buffer_index.Add(y);
                                }
                                else
                                if (Angle2 == Angle3_buf)
                                {
                                    if (Angle3 == Angle2_buf)
                                        Buffer_index.Add(y);

                                }
                            }
                            else
                            if (Angle1 == Angle2_buf)
                            {
                                if (Angle2 == Angle1_buf)
                                {
                                    if (Angle3 == Angle3_buf)
                                        Buffer_index.Add(y);

                                }
                                else
                                if (Angle2 == Angle3_buf)
                                {
                                    if (Angle3 == Angle1_buf)
                                        Buffer_index.Add(y);
                                }
                            }
                            else
                            if (Angle1 == Angle3_buf)
                            {
                                if (Angle2 == Angle1_buf)
                                {
                                    if (Angle3 == Angle2_buf)
                                        Buffer_index.Add(y);

                                }
                                else
                                if (Angle2 == Angle2_buf)
                                {
                                    if (Angle3 == Angle1_buf)
                                        Buffer_index.Add(y);
                                }
                            }
                        }
                    }

                    indexs.Add(Buffer_index);
                }
            }

            for (int i = 0; i < indexs.Count; ++i)
            {
                int Cur_index = 0;

                if (i != Cur_index)
                {
                    while ((Cur_index < indexs.Count) && (i < indexs.Count))
                    {
                        if (Cur_index != i)
                        {
                            bool delete_indx = false;

                            for (int u = 0; u < indexs[i].Count; ++u)
                            {
                                for (int q = 0; q < indexs[Cur_index].Count; ++q)
                                    if (indexs[i][u] == indexs[Cur_index][q])
                                        delete_indx = true;
                            }

                            if (delete_indx)
                            {
                                if (indexs[i].Count > indexs[Cur_index].Count)
                                    indexs.RemoveAt(Cur_index);
                                else
                                    indexs.RemoveAt(i);
                            }
                            else
                                ++Cur_index;
                        }
                        else
                            ++Cur_index;
                    }
                }
            }

            OutputTriangles.Text = "";

            for (int i = 0; i < indexs.Count; ++i)
            {
                OutputTriangles.Text += "Simular triangles:" + Environment.NewLine;
                for (int y = 0; y < indexs[i].Count; ++y)
                {
                    OutputTriangles.Text += "    Triangle: " + " ((" + m_triangles[y].Point_A.X +
                        "," + m_triangles[y].Point_A.Y + "), ("
                        + m_triangles[y].Point_B.X + "," + m_triangles[y].Point_B.Y + 
                        "), (" + m_triangles[y].Point_C.X + "," + m_triangles[y].Point_C.Y + "))" + Environment.NewLine;
                }
            }
        }

        private void BiggestAreaIsosceles_Click(object sender, EventArgs e)
        {

            String Result = "";

            int max_area_index = 0;
            double max_area = 0;

            for (int i = 0; i < m_isosceles.Count; ++i)
                if (max_area < m_isosceles[i].GetSquare())
                {
                    max_area_index = i;
                    max_area = m_isosceles[i].GetSquare();
                }

            if (m_isosceles.Count > 0)
                Result = m_isosceles[max_area_index].ToString();

            OutputIsosceles.Text = Result;
        }
    }
}
