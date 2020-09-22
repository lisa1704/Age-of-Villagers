using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianKings : INation
    {
        public void paint_house(MouseEventArgs e, Graphics g, Pen p)
        {
            int x, y;
            x = e.X;
            y = e.Y;
            Point pt1 = new Point(x, y);
            Point pt2 = new Point(x + 6, y + 8);
            Point pt3 = new Point(x + 2, y + 16);
            Point pt4 = new Point(x - 10, y + 12);
            
            g.DrawLine(p, pt1, pt2);
            g.DrawLine(p, pt2, pt3);
            g.DrawLine(p, pt3, pt4);
            g.DrawLine(p, pt4, pt1);
            g.DrawLine(p, pt1, pt3);
            
        }

        public void paint_tree(MouseEventArgs e, Graphics g, Pen p)
        {
            int x, y;
            x = e.X;
            y = e.Y;
            Point pt1 = new Point(x, y);
            Point pt2 = new Point(x - 2, y - 24);
            Point pt3 = new Point(x - 5, y - 22);
            Point pt4 = new Point(x - 8, y - 20);
            Point pt5 = new Point(x + 2, y - 24);
            Point pt6 = new Point(x + 5, y - 23);
            Point pt7 = new Point(x + 8, y - 23);
            Point pt8 = new Point(x + 3, y - 16);
            Point pt9 = new Point(x - 3, y - 16);
            g.DrawLine(p, pt1, pt3);
            g.DrawLine(p, pt1, pt6);
            g.DrawLine(p, pt8, pt5);
            g.DrawLine(p, pt8, pt7);
            g.DrawLine(p, pt9, pt2);
            g.DrawLine(p, pt9, pt4);
            
        }

        public void paint_waterSource(MouseEventArgs e, Graphics g, Pen p)
        {
            int x, y;
            x = e.X;
            y = e.Y;
            g.DrawArc(p, x - 6, y - 6, 12, 12, 0, 360);
        }
    }

       
    
}
