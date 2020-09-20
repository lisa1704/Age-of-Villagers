using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class EgyptianKings : INation
    {
        public void drawhouse(Point p, Graphics g, Pen pen)
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

        public void drawtree(Point p, Graphics g, Pen pen)
        {
            throw new NotImplementedException();
        }

        public void drawwatersrc(Point p, Graphics g, Pen pen)
        {
            throw new NotImplementedException();
        }
    }
}
