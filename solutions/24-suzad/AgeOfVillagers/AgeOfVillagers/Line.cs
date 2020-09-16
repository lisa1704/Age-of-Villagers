using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Line : IShape
    {
        public Point point1;
        public Point point2;
        public Line(Point point1,Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
        public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, point1, point2);
        }
    }
}
