using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers.shape
{
   class arc : Ishape
    {
        private readonly Point point;
        private float x, y, width, height, startAngle, sweepAngle;

        public arc(Point topLeft, Point bottomRight)
        {
            x = topLeft.X;
            y = topLeft.Y;
            width = bottomRight.X - topLeft.X;
            height = bottomRight.Y - topLeft.Y;
            startAngle = 0;
            sweepAngle = 180;
        }
        public void draw(Graphics g, Pen p)
        {
            g.DrawArc(p, x, y, width, height, startAngle, sweepAngle);
        }
    }
}
