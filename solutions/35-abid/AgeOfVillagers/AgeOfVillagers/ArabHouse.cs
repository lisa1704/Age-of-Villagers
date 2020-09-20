using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabHouse : IHouse
    {
        public void drawHouse(Point p, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics g = panel.CreateGraphics();
            Point p1 = new Point(p.X - 8, p.Y + 16);
            Point p2 = new Point(p1.X + 16, p1.Y);
            Point p3 = new Point(p.X + 8, p.Y - 3);
            Point p4 = new Point(p2.X + 8, p3.Y + 16);
            g.DrawLine(pen, p, p1);
            g.DrawLine(pen, p, p2);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p, p3);
            g.DrawLine(pen, p3, p4);
            g.DrawLine(pen, p2, p4);
        }
    }
}
