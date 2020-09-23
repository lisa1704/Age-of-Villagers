using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class BangladeshHouse : CompositeShape
    {
        Point point;
        public BangladeshHouse(Point point)
        {
            this.point = point;

            Point TopLeft = new Point(point.X - 10, point.Y + 10);
            Point BottomRight = new Point(point.X + 10, point.Y - 10);
            Point TopRight = new Point(BottomRight.X,TopLeft.Y);

            ShapePush(new Triangle(point, TopLeft, TopRight));
            ShapePush(new Rectangle(TopLeft, new Point(TopLeft.X, BottomRight.Y), BottomRight, TopRight));

        }
    }
}
