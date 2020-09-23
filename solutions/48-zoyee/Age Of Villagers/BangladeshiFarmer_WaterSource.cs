using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    public class BangladeshiFarmer_WaterSource : CompositeShape
    {
        public BangladeshiFarmer_WaterSource(Point mainPoint)
        {
            Point point1 = new Point(mainPoint.X - 20, mainPoint.Y + 40);
            Point point2 = new Point(mainPoint.X, mainPoint.Y + 60);
            Point point3 = new Point(mainPoint.X + 20, mainPoint.Y + 40);
            Point point4 = new Point(mainPoint.X + 40, mainPoint.Y + 60);
            Point point5 = new Point(mainPoint.X + 60, mainPoint.Y + 20);
            Point point6 = new Point(mainPoint.X + 40, mainPoint.Y);
            Point point7 = new Point(mainPoint.X + 20, mainPoint.Y + 20);
            Point point8 = new Point(mainPoint.X + 20, mainPoint.Y);

            AddComponent(new Line(mainPoint, point1));
            AddComponent(new Line(point1, point2));
            AddComponent(new Line(point2, point3));
            AddComponent(new Line(point3, point4));
            AddComponent(new Line(point4, point5));
            AddComponent(new Line(point5, point6));
            AddComponent(new Line(point6, point7));
            AddComponent(new Line(point7, point8));
            AddComponent(new Line(point8, mainPoint));
        }
    }
}
