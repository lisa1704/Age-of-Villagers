using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianKings : INation
    {
        public void drawhouse(Point p)
        {
           /* Point p1 = new Point(p.X + 4, p.Y + 16);
            Point p2 = new Point(p.X - 8, p.Y + 13);
            Point p3 = new Point(p.X + 8, p.Y + 9);

            g.DrawLine(pen, p, p1);
            g.DrawLine(pen, p, p2);
            g.DrawLine(pen, p, p3);
            g.DrawLine(pen, p3, p1);
            g.DrawLine(pen, p2, p1);*/
        }

        public void drawtree(Point p)
        {
            /*Point p1 = new Point(p.X, p.Y + 24);

            Point p4 = new Point(p.X - 3, p.Y + 4);
            Point p5 = new Point(p.X + 3, p.Y + 4);
            Point p2 = new Point(p4.X - 4, p.Y + 2);
            Point p3 = new Point(p5.X + 4, p.Y + 2);

            Point p6 = new Point(p3.X + 4, p.Y);
            Point p7 = new Point(p2.X - 4, p.Y);

            Point p8 = new Point(p1.X - 5, p1.Y - 12);
            Point p9 = new Point(p1.X + 5, p1.Y - 12);
            g.DrawLine(pen, p8, p1);
            g.DrawLine(pen, p9, p1);
            g.DrawLine(pen, p8, p7);
            g.DrawLine(pen, p8, p2);
            g.DrawLine(pen, p8, p4);
            g.DrawLine(pen, p3, p9);
            g.DrawLine(pen, p5, p9);
            g.DrawLine(pen, p6, p9);*/
        }

        public void drawwatersrc(Point p)
        {
            //g.DrawArc(pen, p.X, p.Y, 12, 12, 0, 360);
        }
    }
}
