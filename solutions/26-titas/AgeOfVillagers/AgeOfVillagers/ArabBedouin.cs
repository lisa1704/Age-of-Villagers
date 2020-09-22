using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabBedouin : INation
    {
        public void paint_house(MouseEventArgs e, Graphics g, Pen p)
        {
            int x, y;
            x = e.X;
            y = e.Y;
            Point pt1 = new Point(x, y);
            Point pt2 = new Point(x + 5, y - 10);
            Point pt3 = new Point(x + 10, y - 16);
            Point pt4 = new Point(x + 16, y - 5);
            Point pt5 = new Point(x + 10, y);
            g.DrawLine(p, pt1, pt2);
            g.DrawLine(p, pt2, pt3);
            g.DrawLine(p, pt3, pt4);
            g.DrawLine(p, pt4, pt5);
            g.DrawLine(p, pt5, pt1);
            g.DrawLine(p, pt5, pt2);
        }

        public void paint_tree(MouseEventArgs e, Graphics g, Pen p)
        {
            int x, y;
            x = e.X;
            y = e.Y;
            Point pt1 = new Point(x, y);
            Point pt2 = new Point(x - 2, y);
            Point pt3 = new Point(x - 2, y + 12);
            Point pt4 = new Point(x , y + 12);
            Point pt5 = new Point(x , y - 12);
            Point pt6 = new Point(x + 6, y - 9);
            Point pt7 = new Point(x + 8, y - 2);
            Point pt8 = new Point(x - 6, y - 9);
            Point pt9 = new Point(x - 8, y - 2);
            g.DrawLine(p, pt1, pt2);
            g.DrawLine(p, pt2, pt3);
            g.DrawLine(p, pt3, pt4);
            g.DrawLine(p, pt4, pt1);
            g.DrawLine(p, pt1, pt5);
            g.DrawLine(p, pt1, pt6);
            g.DrawLine(p, pt1, pt7);
            g.DrawLine(p, pt1, pt8);
            g.DrawLine(p, pt1, pt9);
        }

        public void paint_waterSource(MouseEventArgs e, Graphics g, Pen p)
        {
            throw new NotImplementedException();
        }
    }
}
