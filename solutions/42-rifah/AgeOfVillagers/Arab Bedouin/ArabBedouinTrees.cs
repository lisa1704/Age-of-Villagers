using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Arab_Bedouin
{
    public class ArabBedouinTrees : Composite
    {

        public ArabBedouinTrees(Point point)
        {
            Point point1 = new Point(point.X + 8, point.Y - 4);
            Point point2 = new Point(point.X - 8, point.Y - 4);
            Point point3 = new Point(point.X + 6, point.Y - 8);
            Point point4 = new Point(point.X - 6, point.Y - 8);
            Point point5 = new Point(point.X, point.Y - 10);
            Point TopLeft = new Point(point.X - 1, point.Y);
            Point RightBottom = new Point(point.X + 1, point.Y + 14);

            AddComponent(new Rectangle(TopLeft, RightBottom));
            AddComponent(new Line(point, point1));
            AddComponent(new Line(point, point2));
            AddComponent(new Line(point, point3));
            AddComponent(new Line(point, point4));
            AddComponent(new Line(point, point5));
        }
    }
}
