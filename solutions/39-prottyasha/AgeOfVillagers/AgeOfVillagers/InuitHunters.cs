using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class InuitHunters : INations
    {
        public void drawhouse(Point p, Graphics g, Pen pen)
        {
            g.DrawArc(pen, p.X, p.Y, 8, 8, 180, 180);
            g.DrawArc(pen, p.X, p.Y, 3, 3, 180, 180);
            Point p1 = new Point(p.X - 8, p.Y);
            Point p2 = new Point(p.X + 8, p.Y);
            g.DrawLine(pen, p1, p2);
        }

        public void drawtree(Point p, Graphics g, Pen pen)
        {
            //do nothing
        }

        public void drawwatersource(Point p, Graphics g, Pen pen)
        {
            //do nothing
        }
    }
}
