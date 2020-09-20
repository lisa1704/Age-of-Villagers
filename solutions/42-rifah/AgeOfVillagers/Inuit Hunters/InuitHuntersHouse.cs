using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Inuit_Hunters
{
    class InuitHuntersHouse : Composite
    {
        public InuitHuntersHouse(Point point)
        {
            Point point1 = new Point(point.X - 12, point.Y - 12);
            Point point2 = new Point(point.X - 4, point.Y - 4);
            Point LeftBottom = new Point(point.X - 12, point.Y);
            Point RightBottom = new Point(point.X + 12, point.Y);

            AddComponent(new Line(LeftBottom, RightBottom));
            AddComponent(new Arc(point.X - 4, point.Y - 4, 8, 8, 180.0F, 180.0F));
            AddComponent(new Arc(point.X - 12, point.Y - 12, 24, 24, 180.0F, 180.0F));
        }
    }
}
