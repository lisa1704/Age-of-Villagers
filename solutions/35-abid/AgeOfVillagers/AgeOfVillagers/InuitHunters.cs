using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InuitHunters : INation
    {
        public void drawhouse(Point p)
        {
           /* g.DrawArc(pen, p.X, p.Y, 16, 16, 180, 180);
            g.DrawArc(pen, p.X + 5, p.Y + 5, 6, 6, 180, 180);
            Point p1 = new Point(p.X, p.Y + 8);
            Point p2 = new Point(p1.X + 16, p1.Y);
            g.DrawLine(pen, p1, p2);*/
        }

        public void drawtree(Point p)
        {
            //no implementation
        }

        public void drawwatersrc(Point p)
        {
            //no implementation
        }
    }
}
