using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Triangle : IShape
    {
        public Point point1;
        public Point point2;
        public Point point3;
        public Triangle(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }
        public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, point1, point2);
            graphics.DrawLine(pen, point2, point3);
            graphics.DrawLine(pen, point3, point1);
        }
    }
}
