using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class ArabHouse:CompositeShape
    {
        Point point;

        public ArabHouse(Point point)
        {
            this.point = point;

            Point TopLeft = new Point(point.X - 24, point.Y + 24);
            Point BottomRight = new Point(point.X + 24, TopLeft.Y);

            ShapePush (new Triangle(point, TopLeft, BottomRight));
            ShapePush(new Rectangle(point, BottomRight, new Point(BottomRight.X + 18, BottomRight.Y - 15), new Point(point.X + 18, point.Y - 15)));

        }
    }
}
