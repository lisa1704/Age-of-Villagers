using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Shapes
{
    class Circle : IShape
    {
        private readonly Point point;
        private float x, y, width, height, startAngle, sweepAngle;

        public Circle(Point topLeft, Point bottomRight)
        {
            x = topLeft.X;
            y = topLeft.Y;
            width = bottomRight.X - topLeft.X;
            height = bottomRight.Y - topLeft.Y;
            startAngle = 0;
            sweepAngle = 360;
        }
        public void draw(Graphics g, Pen p)
        {
            g.DrawArc(p, x, y, width, height, startAngle, sweepAngle);
        }
    }
}
