﻿using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianKingsHouse : Composite
    {
        public EgyptianKingsHouse(Point point)
        {
            Point point1 = new Point(point.X - 9, point.Y + 14);
            Point point2 = new Point(point.X + 4, point.Y + 16);
            Point point3 = new Point(point.X + 7, point.Y + 10);

            AddComponent(new Triangle(point2, point1, point));
            AddComponent(new Triangle(point3, point2, point));
        }
    }
}