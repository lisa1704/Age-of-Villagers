using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BangladeshiTree : ITree
    {
        public void drawTree(Point p, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics g = panel.CreateGraphics();
            g.DrawArc(pen, p.X, p.Y, 16, 16, 0, 360);
            Point p1 = new Point(p.X + 7, p.Y + 8);
            Point p2 = new Point(p.X + 9, p.Y + 8);
            Point p3 = new Point(p1.X, p1.Y + 13);
            Point p4 = new Point(p2.X, p2.Y + 13);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p1, p3);
            g.DrawLine(pen, p4, p2);
            g.DrawLine(pen, p3, p4);
        }
    }
}
