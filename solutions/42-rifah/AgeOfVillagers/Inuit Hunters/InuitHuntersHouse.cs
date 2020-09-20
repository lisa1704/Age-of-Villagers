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
            Point point1 = new Point(point.X - 40, point.Y - 40);
            Point point2 = new Point(point.X - 10, point.Y - 10);
            Point LeftBottom = new Point(point.X - 40, point.Y);
            Point RightBottom = new Point(point.X + 40, point.Y);

            AddComponent(new Line(LeftBottom, RightBottom));
            AddComponent(new Arc(point.X - 10, point.Y - 10, 20, 20, 180.0F, 180.0F));
            AddComponent(new Arc(point.X - 40, point.Y - 40, 80, 80, 180.0F, 180.0F));
        }
    }
}
