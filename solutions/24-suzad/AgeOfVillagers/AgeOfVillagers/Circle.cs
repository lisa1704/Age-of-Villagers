using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Circle : IShape
    {
        public Point point;
        public int height;
        public int width;
        public Circle(Point point, int height, int width)
        {
            this.point = point;
            this.height = height;
            this.width = width;
        }
        public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            graphics.DrawArc(pen, point.X, point.Y, width, height, 0, 360);
        }
    }
}
