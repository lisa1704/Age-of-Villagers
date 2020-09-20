using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianHouse : IHouse
    {
        public void drawHouse(Point p, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics g = panel.CreateGraphics();
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
