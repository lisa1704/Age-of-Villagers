using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    public class Arc : IShape
    {
        private readonly Point point1;
        private readonly float width;
        private readonly float height;
        private readonly float startAngle;
        private readonly float sweepAngle;

        public Arc(Point point1, float width, float height, float startAngle, float sweepAngle)
        {
            this.point1 = point1;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }
        public void draw(Graphics graphics, Pen pen)
        {
            graphics.DrawArc(pen, point1.X, point1.Y, width, height, startAngle, sweepAngle);
        }
    }
}
