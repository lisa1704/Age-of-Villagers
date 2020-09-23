using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class ArabTree: CompositeShape
    {
        Point point;
        public ArabTree(Point point)
        {
            this.point = point;

            Point TopRight = new Point(point.X + 3, point.Y);
            Point BottomLeft = new Point(point.X, point.Y + 12);
            Point BottomRight = new Point(point.X + 3, point.Y + 12);

            int mid_X = (point.X + TopRight.X) / 2;
            int mid_Y = (point.Y + TopRight.Y) / 2;
            Point MidPoint = new Point(mid_X, mid_Y);
            
            
            ShapePush(new Rectangle(point, BottomLeft, BottomRight, TopRight));
            ShapePush(new Line(MidPoint, new Point(mid_X, mid_Y - 14)));
            ShapePush(new Line(MidPoint, new Point(mid_X + 6, mid_Y - 14)));
            ShapePush(new Line(MidPoint, new Point(TopRight.X + 12, TopRight.Y - 10)));
            ShapePush(new Line(MidPoint, new Point(mid_X - 6, mid_Y - 12)));
            ShapePush(new Line(point, new Point(point.X - 10, point.Y - 10)));
        }
    }
}
