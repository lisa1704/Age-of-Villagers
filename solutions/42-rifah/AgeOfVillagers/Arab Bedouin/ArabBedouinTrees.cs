using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Arab_Bedouin
{
    class ArabBedouinTrees : Composite
    {

        public ArabBedouinTrees(Point point)
        {
            Point point1 = new Point(point.X + 30, point.Y - 10);
            Point point2 = new Point(point.X - 30, point.Y - 10);
            Point point3 = new Point(point.X + 25, point.Y - 20);
            Point point4 = new Point(point.X - 25, point.Y - 20);
            Point point5 = new Point(point.X, point.Y - 30);
            Point TopLeft = new Point(point.X - 3, point.Y);
            Point RightBottom = new Point(point.X + 3, point.Y + 50);

            AddComponent(new Rectangle(TopLeft, RightBottom));
            AddComponent(new Line(point, point1));
            AddComponent(new Line(point, point2));
            AddComponent(new Line(point, point3));
            AddComponent(new Line(point, point4));
            AddComponent(new Line(point, point5));
        }
    }
}
