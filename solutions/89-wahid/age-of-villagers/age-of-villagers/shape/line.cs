using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers.shape
{
    class line : Ishape
    {
        private Point point1, point2;
        public line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
        public void draw(Graphics g, Pen p)
        {
            g.DrawLine(p, point1, point2);
        }
    }
}
