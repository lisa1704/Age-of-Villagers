using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class InuitHouse : IHouse
    {
        public void drawHouse(Point p, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics g = panel.CreateGraphics();
            g.DrawArc(pen, p.X, p.Y, 16, 16, 180, 180);
            g.DrawArc(pen, p.X + 5, p.Y + 5, 6, 6, 180, 180);
            Point p1 = new Point(p.X, p.Y + 8);
            Point p2 = new Point(p1.X + 16, p1.Y);
            g.DrawLine(pen, p1, p2);
        }
    }
}
