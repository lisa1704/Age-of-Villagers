using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BangladeshiFarmers : INations
    {
        public void drawhouse(Point p, Graphics g, Pen pen)
        {
            Point p1 = new Point(p.X - 8, p.Y - 8);
            Point p2 = new Point(p1.X + 16, p1.Y);
            Point p3 = new Point(p1.X, p1.Y - 8);
            Point p4 = new Point(p3.X + 16, p3.Y);
            g.DrawLine(pen, p, p1);
            g.DrawLine(pen, p, p2);
            g.DrawLine(pen, p2, p1);
            g.DrawLine(pen, p3, p1);
            g.DrawLine(pen, p2, p4);
            g.DrawLine(pen, p3, p4);
        }

        public void drawtree(Point p, Graphics g, Pen pen)
        {
            g.DrawArc(pen, p.X, p.Y, 16, 16, 0, 360);
            Point p1 = new Point(p.X - 2, p.Y);
            Point p2 = new Point(p.X + 2, p.Y);
            Point p3 = new Point(p1.X, p1.Y - 8);
            Point p4 = new Point(p2.X, p3.Y);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p1, p3);
            g.DrawLine(pen, p4, p2);
            g.DrawLine(pen, p3, p4);
        }

        public void drawwatersource(Point p, Graphics g, Pen pen)
        {
            Point p1 = new Point(p.X - 12, p.Y - 8);
            Point p2 = new Point(p.X + 12, p1.Y);
            Point p3 = new Point(p.X, p.Y - 11);
            Point p4 = new Point(p.X, p.Y - 5);
            Point p5 = new Point(p1.X + 7, p.Y);
            Point p6 = new Point(p5.X + 10, p.Y);
            Point p7 = new Point(p5.X, p5.Y - 16);
            Point p8 = new Point(p6.X, p6.Y - 16);
            g.DrawLine(pen, p1, p5);
            g.DrawLine(pen, p1, p7);
            g.DrawLine(pen, p5, p);
            g.DrawLine(pen, p, p4);
            g.DrawLine(pen, p6, p2);
            g.DrawLine(pen, p8, p3);
            g.DrawLine(pen, p8, p2);
            g.DrawLine(pen, p6, p4);
            g.DrawLine(pen, p3, p7);
        }
    }
}
