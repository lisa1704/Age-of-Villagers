﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BangladeshiFarmers : INation
    {
        public void drawhouse(Point p, Graphics g, Pen pen)
        {
            Point p1 = new Point(p.X + 8, p.Y + 8);
            Point p2 = new Point(p1.X - 16, p1.Y);
            Point p3 = new Point(p1.X, p1.Y + 8);
            Point p4 = new Point(p3.X - 16, p3.Y);
            g.DrawLine(pen, p, p1);
            g.DrawLine(pen, p, p2);
            g.DrawLine(pen, p2, p1);
            g.DrawLine(pen, p3, p1);
            g.DrawLine(pen, p2, p4);
            g.DrawLine(pen, p3, p4);
        }

        public void drawtree(Point p, Graphics g, Pen pen)
        {
            throw new NotImplementedException();
        }

        public void drawwatersrc(Point p, Graphics g, Pen pen)
        {
            throw new NotImplementedException();
        }
    }
}
