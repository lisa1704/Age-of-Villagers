﻿using System;
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
            throw new NotImplementedException();
        }

        public void paint_waterSource(MouseEventArgs e, Graphics g, Pen p)
        {
            throw new NotImplementedException();
        }
    }
}
