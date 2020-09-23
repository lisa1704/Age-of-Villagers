using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class EgyptHouse:CompositeShape
    {
        Point point;
        public EgyptHouse(Point point)
        {
            this.point = point;
            Point TopLeft = new Point(point.X - 8, point.Y + 24);
            Point BottomRight = new Point(point.X + 8, point.Y + 16);
            Point TopRight = new Point(BottomRight.X, TopLeft.Y);
            Point BottomBehind = new Point(TopRight.X + 4, TopRight.Y - 16);


            ShapePush(new Triangle(point,TopLeft,TopRight));
            ShapePush(new Line(point,BottomBehind));
            ShapePush(new Line(TopRight,BottomBehind));

        }
    }
}
