using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class ArabBedouins : INations
    {
        Pen pen = new Pen(Color.Yellow);
        public void drawhouse(Point p, Graphics g)
        {
            Point p1 = new Point(p.X - 8, p.Y - 16);
            Point p2 = new Point(p.X + 16, p.Y);
            Point p3 = new Point(p.X + 8, p.Y + 3);
            Point p4 = new Point(p3.X, p3.Y - 16);
            g.DrawLine(pen, p, p1);
            g.DrawLine(pen, p, p2);
            g.DrawLine(pen, p, p3);
            g.DrawLine(pen, p3, p4);
            g.DrawLine(pen, p2, p4);
        }

        public void drawtree(Point p, Graphics g)
        {
            throw new NotImplementedException();
        }

        public void drawwatersource(Point p, Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
