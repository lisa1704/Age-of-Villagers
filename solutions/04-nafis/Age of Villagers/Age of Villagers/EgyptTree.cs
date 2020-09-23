using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class EgyptTree:CompositeShape
    {
        Point point;

        public EgyptTree(Point point)
        {
            this.point = point;

            Point TopRight = new Point(point.X + 8, point.Y - 12);
            Point TopLeft = new Point(point.X - 8, point.Y - 12);

            ShapePush(new Line(point, TopLeft));
            ShapePush(new Line(point, TopRight));
            
            ShapePush(new Line(TopRight, new Point(TopRight.X + 8,TopRight.Y - 8)));
            ShapePush(new Line(TopRight, new Point(TopRight.X - 8, TopRight.Y - 8)));
            ShapePush(new Line(TopRight, new Point(TopRight.X, TopRight.Y - 12)));

            ShapePush(new Line(TopLeft, new Point(TopLeft.X + 8, TopLeft.Y - 8)));
            ShapePush(new Line(TopLeft, new Point(TopLeft.X - 8, TopLeft.Y - 8)));
            ShapePush(new Line(TopLeft, new Point(TopLeft.X, TopLeft.Y - 12)));

        }

    }
}
