using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    class BDwatersrc : IComplexShape
    {
        Pen pen = new Pen(Color.Blue);
        public void drawComponent(Graphics g, Point p)
        {
            Point p1 = new Point(p.X - 18, p.Y - 12);
            Point p2 = new Point(p.X + 18, p1.Y);
            Point p3 = new Point(p.X, p.Y - 15);
            Point p4 = new Point(p.X, p.Y - 8);
            Point p5 = new Point(p1.X + 7, p.Y);
            Point p6 = new Point(p5.X + 14, p.Y);
            Point p7 = new Point(p5.X, p5.Y - 24);
            Point p8 = new Point(p6.X, p6.Y - 24);
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
