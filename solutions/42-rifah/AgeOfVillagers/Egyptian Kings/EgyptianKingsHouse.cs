using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Egyptian_Kings
{
    class EgyptianKingsHouse : Composite
    {

        public EgyptianKingsHouse(Point point)
        {
            Point point1 = new Point(point.X - 25, point.Y + 45);
            Point point2 = new Point(point.X + 20, point.Y + 50);
            Point point3 = new Point(point.X + 30, point.Y + 25);

            AddComponent(new Triangle(point2, point1, point));
            AddComponent(new Triangle(point3, point2, point));
        }
    }
}
