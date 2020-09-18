using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Egyptian_Kings
{
    class EgyptianKingsTrees : Composite
    {

        public EgyptianKingsTrees(Point point)
        {
            Point point1 = new Point(point.X + 20, point.Y - 55);
            Point point2 = new Point(point.X - 20, point.Y - 52);
            Point point3 = new Point(point.X + 11, point.Y - 30);
            Point point4 = new Point(point.X + 35, point.Y - 55);
            Point point5 = new Point(point.X + 12, point.Y - 55);
            Point point6 = new Point(point.X - 12, point.Y - 30);
            Point point7 = new Point(point.X - 10, point.Y - 55);
            Point point8 = new Point(point.X - 35, point.Y - 48);

            AddComponent(new Line(point, point1));
            AddComponent(new Line(point, point2));
            AddComponent(new Line(point3, point4));
            AddComponent(new Line(point3, point5));
            AddComponent(new Line(point6, point7));
            AddComponent(new Line(point6, point8));
        }
    }
}
