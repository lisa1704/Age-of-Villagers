using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Bangladeshi_Farmers
{
    public class BDFarmersWatersource : Composite
    {
        public BDFarmersWatersource(Point Point1)
        {
            Point point2 = new Point(Point1.X - 6, Point1.Y + 2);
            Point point3 = new Point(Point1.X - 11, Point1.Y + 14);
            Point point4 = new Point(Point1.X - 3, Point1.Y + 20);
            Point point5 = new Point(Point1.X + 5, Point1.Y + 12);
            Point point6 = new Point(Point1.X + 12, Point1.Y + 16);
            Point point7 = new Point(Point1.X + 15, Point1.Y + 6);
            Point point8 = new Point(Point1.X + 8, Point1.Y - 2);
            Point point9 = new Point(Point1.X, Point1.Y + 7);

            AddComponent(new Line(Point1, point2));
            AddComponent(new Line(point2, point3));
            AddComponent(new Line(point3, point4));
            AddComponent(new Line(point4, point5));
            AddComponent(new Line(point5, point6));
            AddComponent(new Line(point6, point7));
            AddComponent(new Line(point7, point8));
            AddComponent(new Line(point8, point9));
            AddComponent(new Line(point9, Point1));
        }
    }
}
