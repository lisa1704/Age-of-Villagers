using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Shape
{
    class Arc : IShape
    {
        private readonly Point point;
        private float x, y, width, height, startAngle, sweepAngle;

        public Arc(Point topLeft, Point bottomRight)
        {
            x = topLeft.X;
            y = topLeft.Y;
            width = bottomRight.X - topLeft.X;
            height = bottomRight.Y - topLeft.Y;
            startAngle = 0;
            sweepAngle = 180;
        }

        public void AddComponent(IShape shape)
        {
            throw new NotImplementedException();
        }

        public void Draw(Graphics g, Pen p)
        {
            g.DrawArc(p, x, y, width, height, startAngle, sweepAngle);
        }
    }
}