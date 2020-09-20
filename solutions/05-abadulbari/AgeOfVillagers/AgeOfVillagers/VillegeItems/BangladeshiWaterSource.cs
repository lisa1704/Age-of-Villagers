using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.VillegeItems
{
    class BangladeshiWaterSource : VillageItem
    {
        private readonly Point point1, point2, point3, point4, point5, point6, point7, point8, point9;

        public BangladeshiWaterSource(Point point)
        {
            point1 = point;
            point2 = new Point(point.X+6, point.Y-6);
            point3 = new Point(point.X+12, point.Y-7);
            point4 = new Point(point.X+13, point.Y-1);
            point5 = new Point(point.X+18, point.Y-8);
            point6 = new Point(point.X+24, point.Y-1);
            point7 = new Point(point.X+20, point.Y+7);
            point8 = new Point(point.X+15, point.Y+4);
            point9 = new Point(point.X+8, point.Y+8);
            addItem(new Line(point1, point2));
            addItem(new Line(point2, point3));
            addItem(new Line(point3, point4));
            addItem(new Line(point4, point5));
            addItem(new Line(point5, point6));
            addItem(new Line(point6, point7));
            addItem(new Line(point7, point8));
            addItem(new Line(point8, point9));
            addItem(new Line(point9, point1));
        }
    }
}
