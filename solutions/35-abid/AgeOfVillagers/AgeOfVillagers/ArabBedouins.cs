using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabBedouins : INation
    {
        public void drawhouse(Point p)
        {
           /* Point p1 = new Point(p.X - 8, p.Y + 16);
            Point p2 = new Point(p1.X + 16, p1.Y);
            Point p3 = new Point(p.X + 8, p.Y - 3);
            Point p4 = new Point(p2.X + 8, p3.Y + 16);
            g.DrawLine(pen, p, p1);
            g.DrawLine(pen, p, p2);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p, p3);
            g.DrawLine(pen, p3, p4);
            g.DrawLine(pen, p2, p4);*/
        }

        public void drawtree(Point p)
        {
            /*Point p1 = new Point(p.X, p.Y - 12);
            Point p2 = new Point(p1.X - 2, p1.Y);
            Point p3 = new Point(p1.X + 2, p1.Y);
            Point p4 = new Point(p2.X, p2.Y + 12);
            Point p5 = new Point(p3.X, p3.Y + 12);
            Point p7 = new Point(p.X - 4, p1.Y - 12);
            Point p6 = new Point(p.X - 8, p1.Y - 12);
            Point p8 = new Point(p.X + 4, p7.Y);
            Point p9 = new Point(p.X + 8, p6.Y);
            g.DrawLine(pen, p, p1);
            g.DrawLine(pen, p2, p3);
            g.DrawLine(pen, p2, p4);
            g.DrawLine(pen, p4, p5);
            g.DrawLine(pen, p3, p5);
            g.DrawLine(pen, p6, p1);
            g.DrawLine(pen, p7, p1);
            g.DrawLine(pen, p8, p1);
            g.DrawLine(pen, p9, p1);*/
        }

        public void drawwatersrc(Point p)
        {
            //no implementation
        }
    }
}
