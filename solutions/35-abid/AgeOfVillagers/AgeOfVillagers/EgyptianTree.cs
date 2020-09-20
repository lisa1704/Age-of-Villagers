using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianTree : ITree
    {
        public void drawTree(Point p, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics g = panel.CreateGraphics();
            Point p1 = new Point(p.X, p.Y + 24);

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
            g.DrawLine(pen, p6, p9);
        }
    }
}
