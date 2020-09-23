﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Shapes
{
    class Circle
    {
        Graphics graphics;
        Pen pen = new Pen(Color.Black);
        Point point;
        int radius;

        public Circle(Graphics g, Point p, int r)
        {
            graphics = g;
            point = p;
            radius = r;
        }

        public void Draw()
        {
            graphics.DrawArc(pen, point.X, point.Y,radius,radius, 0, 360);
        }
    }
}
