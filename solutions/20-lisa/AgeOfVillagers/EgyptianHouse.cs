using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianHouse : CompositeShape
    {
        public EgyptianHouse(Point point)
        {
            Point p1 = new Point(point.X - 20, point.Y + 50);
            Point p2 = new Point(point.X + 25, point.Y + 55);
            Point p3 = new Point(point.X + 35, point.Y + 30);
            AddComponent(new Triangle(p2, p1, point));
            AddComponent(new Triangle(p3, p2, point));
        }
    }
}
