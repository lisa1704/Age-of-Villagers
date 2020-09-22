using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public class BdTree : IComponent
    {
        public void draw(Point p, Graphics g, Pen pen)
        {
            g.DrawArc(pen, p.X, p.Y, 16, 16, 0, 360);
            Point pc = new Point(p.X + 8, p.Y + 16);
            Point p1 = new Point(pc.X - 2, pc.Y);
            Point p2 = new Point(pc.X + 2, pc.Y);
            Point p3 = new Point(p1.X, p1.Y + 16);
            Point p4 = new Point(p2.X, p3.Y);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p1, p3);
            g.DrawLine(pen, p4, p2);
            g.DrawLine(pen, p3, p4);
        }
    }
}
