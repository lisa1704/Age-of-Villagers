using age_of_villagers.shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers.villageitem
{
    public class bangladeshiwatersource : villageitem
    {
        private readonly Point point1, point2, point3, point4, point5, point6, point7, point8, point9;

        public bangladeshiwatersource(Point point)
        {
            point1 = point;
            point2 = new Point(point.X + 6, point.Y - 6);
            point3 = new Point(point.X + 12, point.Y - 7);
            point4 = new Point(point.X + 13, point.Y - 1);
            point5 = new Point(point.X + 18, point.Y - 8);
            point6 = new Point(point.X + 24, point.Y - 1);
            point7 = new Point(point.X + 20, point.Y + 7);
            point8 = new Point(point.X + 15, point.Y + 4);
            point9 = new Point(point.X + 8, point.Y + 8);
            Additem(new line(point1, point2));
            Additem(new line(point2, point3));
            Additem(new line(point3, point4));
            Additem(new line(point4, point5));
            Additem(new line(point5, point6));
            Additem(new line(point6, point7));
            Additem(new line(point7, point8));
            Additem(new line(point8, point9));
            Additem(new line(point9, point1));
        }
    }
}
