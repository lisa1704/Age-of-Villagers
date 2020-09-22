using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BangladeshiWatersrc : IWatersrc
    {
        public void drawWatersrc(Point p, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics g = panel.CreateGraphics();
            Point p1 = new Point(p.X - 12, p.Y + 8);
            Point p2 = new Point(p.X + 12, p1.Y);
            Point p3 = new Point(p.X, p.Y + 11);
            Point p4 = new Point(p.X, p.Y + 5);
            Point p5 = new Point(p1.X + 7, p.Y);
            Point p6 = new Point(p5.X + 10, p.Y);
            Point p7 = new Point(p5.X, p5.Y + 16);
            Point p8 = new Point(p6.X, p6.Y + 16);
            g.DrawLine(pen, p1, p5);
            g.DrawLine(pen, p1, p7);
            g.DrawLine(pen, p5, p);
            g.DrawLine(pen, p, p4);
            g.DrawLine(pen, p6, p2);
            g.DrawLine(pen, p8, p3);
            g.DrawLine(pen, p8, p2);
            g.DrawLine(pen, p6, p4);
            g.DrawLine(pen, p3, p7);
        }
    }
}
