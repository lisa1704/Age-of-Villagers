using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Age_of_Villagers
{
    class InuitHouse:CompositeShape
    {
        Point point;

        public InuitHouse(Point point)
        {
            this.point = point;
            ShapePush(new Arc(point, 30, 30, 0, -180));
            ShapePush(new Arc(new Point(point.X + 10, point.Y + 10), 10, 10, 0, -180));
            ShapePush(new Line(new Point(point.X, point.Y + 15), new Point(point.X + 30, point.Y + 15)));

        }
    }
}
