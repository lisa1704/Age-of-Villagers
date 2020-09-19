using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    public class Rectangle : CompositeShape
    {
        private readonly Point point1;
        private readonly Point point2;
        private readonly Point point3;
        private readonly Point point4;

        public Rectangle(Point point1, Point point2, Point point3,Point point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;

            ShapePush(new Line(point1, point2));
            ShapePush(new Line(point2, point3));
            ShapePush(new Line(point3, point4));
            ShapePush(new Line(point4, point1));
        }
    }
}
