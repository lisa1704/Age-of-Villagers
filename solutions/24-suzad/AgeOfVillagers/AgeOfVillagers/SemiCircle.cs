using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class SemiCircle : IShape
    {
        public Point arcPoint;
        public Point linePoint1;
        public Point linePoint2;
        public int height;
        public int width;

        public SemiCircle(Point arcPoint, Point linePoint1, Point linePoint2, int height, int width)
        {
            this.arcPoint = arcPoint;
            this.linePoint1 = linePoint1;
            this.linePoint2 = linePoint2;
            this.height = height;
            this.width = width;
        }
        public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, linePoint1, linePoint2);
            graphics.DrawArc(pen, arcPoint.X, arcPoint.Y, width, height, 180, 180);
        }
    }
}
