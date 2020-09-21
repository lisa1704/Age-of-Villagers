using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    class EgyptTree : IComponent
    {
        public void draw(Point p, Graphics g, Pen pen)
        {
            Point p1 = new Point(p.X, p.Y + 24);

            Point p4 = new Point(p.X - 2, p.Y);
            Point p5 = new Point(p.X + 2, p.Y);
            Point p2 = new Point(p4.X - 3, p.Y + 2);
            Point p3 = new Point(p5.X + 3, p.Y + 2);

            Point p6 = new Point(p3.X + 3, p.Y + 4);
            Point p7 = new Point(p2.X - 3, p.Y + 4);

            Point p8 = new Point(p1.X - 5, p1.Y - 12);
            Point p9 = new Point(p1.X + 5, p1.Y - 12);
            g.DrawLine(pen, p8, p1);
            g.DrawLine(pen, p9, p1);
            g.DrawLine(pen, p8, p7);
            g.DrawLine(pen, p8, p2);
            g.DrawLine(pen, p8, p4);
            g.DrawLine(pen, p3, p9);
            g.DrawLine(pen, p5, p9);
            g.DrawLine(pen, p6, p9);
        }
    }
}
