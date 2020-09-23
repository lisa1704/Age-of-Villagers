﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Shapes
{
    class Line : IShape
    {
        private Point p1, p2;
        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, p1, p2);
        }
    }
}
