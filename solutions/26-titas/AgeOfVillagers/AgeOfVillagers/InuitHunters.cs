using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InuitHunters : INation
    {
        public void paint_house(MouseEventArgs e, Graphics g, Pen p)
        {
            int x, y;
            x = e.X;
            y = e.Y;
            
            Point pt2 = new Point(x + 8, y);
            Point pt3 = new Point(x - 8, y);
            g.DrawArc(p, x - 8, y - 8, 16, 16, 0, -180);
            g.DrawArc(p, x - 3, y - 3, 6, 6, 0, -180);
            g.DrawLine(p, pt2, pt3);
        }

        public void paint_tree(MouseEventArgs e, Graphics g, Pen p)
        {
            throw new NotImplementedException();
        }

        public void paint_waterSource(MouseEventArgs e, Graphics g, Pen p)
        {
            throw new NotImplementedException();
        }
    }
}
