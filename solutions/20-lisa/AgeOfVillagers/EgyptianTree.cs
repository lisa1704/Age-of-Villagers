using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianTree : CompositeShape
    {
        public EgyptianTree(Point point)
        {
            Point p1 = new Point(point.X + 30, point.Y - 45);
            Point p2 = new Point(point.X - 10, point.Y - 44);
            Point p3 = new Point(point.X + 14, point.Y - 20);
            Point p4 = new Point(point.X + 30, point.Y - 45);
            Point p5 = new Point(point.X + 15, point.Y - 45);
            Point p6 = new Point(point.X + 15, point.Y - 20);
            Point p7 = new Point(point.X + 10, point.Y - 45);
            Point p8 = new Point(point.X + 35, point.Y - 50);

            AddComponent(new Line(point, p1));
            AddComponent(new Line(point, p2));
            AddComponent(new Line(p3, p4));
            AddComponent(new Line(p3, p5));
            AddComponent(new Line(p6, p7));
            AddComponent(new Line(p6, p8));

        }
    }
}
