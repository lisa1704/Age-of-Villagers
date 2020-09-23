using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class BangladeshTree:CompositeShape
    {
        Point point;

        public BangladeshTree(Point point)
        {
            this.point = point;

            Point TopPoint = new Point(point.X + 6, point.Y + 10);
            Point TopRight = new Point(TopPoint.X + 3, TopPoint.Y);
            Point BootomLeft = new Point(TopPoint.X, TopPoint.Y + 12);
            Point BottomRight = new Point(TopPoint.X + 3, TopPoint.Y + 12);

            ShapePush(new Arc(point, 16, 16, 0, 180));
            ShapePush(new Arc(point, 16, 16, 0, 1 - 180));

        }


    }
}
