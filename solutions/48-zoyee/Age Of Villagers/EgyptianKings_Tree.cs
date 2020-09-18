using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    class EgyptianKings_Tree : CompositeShape
    {
        public EgyptianKings_Tree(Point mainPoint)
        {
            Point point1 = new Point(mainPoint.X + 25, mainPoint.Y - 50);
            Point point2 = new Point(mainPoint.X - 25, mainPoint.Y - 50);
            Point point3 = new Point(mainPoint.X + 15, mainPoint.Y - 30);
            Point point4 = new Point(mainPoint.X + 40, mainPoint.Y - 45);
            Point point5 = new Point(mainPoint.X + 10, mainPoint.Y - 50);
            Point point6 = new Point(mainPoint.X - 16, mainPoint.Y - 30);
            Point point7 = new Point(mainPoint.X - 10, mainPoint.Y - 50);
            Point point8 = new Point(mainPoint.X - 35, mainPoint.Y - 50);

            AddComponent(new Line(mainPoint, point1));
            AddComponent(new Line(mainPoint, point2));
            AddComponent(new Line(point3, point4));
            AddComponent(new Line(point3, point5));
            AddComponent(new Line(point6, point7));
            AddComponent(new Line(point6, point8));
        }
    }
}
