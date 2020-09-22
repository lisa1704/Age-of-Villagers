using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Age_of_Villagers.Age_of_Villagers
{
    class Triangle : CShape
    {
        private readonly Point pt1;
        private readonly Point pt2;
        private readonly Point pt3;
        public Triangle(Point pt1, Point pt2, Point pt3)
        {
            this.pt1 = pt1;
            this.pt2 = pt2;
            this.pt3 = pt3;
        }

        public void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, pt1.X, pt1.Y, pt2.X, pt1.Y);
            g.DrawLine(pen, pt2.X, pt1.Y, pt3.X, pt3.Y);
            g.DrawLine(pen, pt1.X, pt1.Y, pt3.X, pt3.Y);
        }

    }
}