using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BangladeshiFarmers : INations
    {
        Pen pen = new Pen(Color.Green);
        public void drawhouse(Point p, Graphics g)
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

        public void drawtree(Point p, Graphics g)
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

        public void drawwatersource(Point p, Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
