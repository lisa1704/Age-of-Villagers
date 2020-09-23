﻿using System.Drawing;

namespace AOV
{
    class Rectangle : CompoundShape
    {
        private Point x2;
        private Point x4;
        public Rectangle(Point x1, Point x3)
        {
            x2 = new Point(x3.X, x1.Y);
            x4 = new Point(x1.X, x3.Y);

            AddShape(new DrawLine(x1, x4));
            AddShape(new DrawLine(x1, x2));
            AddShape(new DrawLine(x3, x4));
            AddShape(new DrawLine(x2, x3));
        }
    }
}
