using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    public class Line : IShape
    {
        private readonly Point point1;
        private readonly Point point2;

        public Line(Point x1, Point x2)
        {
            this.point1 = x1;
            this.point2 = x2;
        }

        public void draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen,point1,point2);
        }
    }
}
