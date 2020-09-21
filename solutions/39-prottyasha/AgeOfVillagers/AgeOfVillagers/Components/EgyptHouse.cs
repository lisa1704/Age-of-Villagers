using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    class EgyptHouse : IComponent
    {
        public void draw(Point p, Graphics g, Pen pen)
        {
            Point p1 = new Point(p.X + 4, p.Y + 16);
            Point p2 = new Point(p.X - 8, p.Y + 13);
            Point p3 = new Point(p.X + 8, p.Y + 9);

            g.DrawLine(pen, p, p1);
            g.DrawLine(pen, p, p2);
            g.DrawLine(pen, p, p3);
            g.DrawLine(pen, p3, p1);
            g.DrawLine(pen, p2, p1);
        }
    }
}
