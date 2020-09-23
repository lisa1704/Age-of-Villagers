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
            Point point1 = new Point(point.X + 10, point.Y - 5);
            Point point2 = new Point(point.X - 10, point.Y - 5);
            Point point3 = new Point(point.X + 6, point.Y - 8);
            Point point4 = new Point(point.X - 6, point.Y - 8);
            Point point5 = new Point(point.X, point.Y - 10);
            Point leftPoint1 = new Point(point.X + 10, point.Y - 5);
            Point rightPoint1 = new Point(point.X - 10, point.Y - 5);
            Point leftPoint2 = new Point(point.X + 6, point.Y - 8);
            Point rightPoint2 = new Point(point.X - 6, point.Y - 8);
            Point topMost = new Point(point.X, point.Y - 10);
            Point TopLeft = new Point(point.X - 1, point.Y);
            Point RightBottom = new Point(point.X + 1, point.Y + 14);

            AddComponent(new Rectangle(TopLeft, RightBottom));
            AddComponent(new Line(point, point1));
            AddComponent(new Line(point, point2));
            AddComponent(new Line(point, point3));
            AddComponent(new Line(point, point4));
            AddComponent(new Line(point, point5));
            AddComponent(new Line(point, leftPoint1));
            AddComponent(new Line(point, rightPoint1));
            AddComponent(new Line(point, leftPoint2));
            AddComponent(new Line(point, rightPoint2));
            AddComponent(new Line(point, topMost));
        }
    }
}