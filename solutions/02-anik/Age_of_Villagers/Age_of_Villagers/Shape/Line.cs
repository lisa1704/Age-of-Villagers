using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Shape
{
    class Line : IShape
    {
        private Point p01, p02;
        public Line(Point point1, Point point2)
        {
            p01 = point1;
            p02 = point2;
        }
        public void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, p01, p02);
        }
    }
}
