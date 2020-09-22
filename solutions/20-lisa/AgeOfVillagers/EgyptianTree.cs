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
            Point p1 = new Point(point.X - 20, point.Y - 25);
            Point p2 = new Point(point.X + 20, point.Y - 25);
            Point p3 = new Point(p1.X + 15, p1.Y - 12);
            Point p4 = new Point(p1.X - 15, p1.Y - 12);
            Point p5 = new Point(p1.X, p1.Y - 15);
            Point p6 = new Point(p2.X + 15, p2.Y - 12);
            Point p7 = new Point(p2.X - 15, p2.Y - 12);
            Point p8 = new Point(p2.X , p2.Y - 12);

            AddComponent(new Line(point, p1));
            AddComponent(new Line(point, p2));
            AddComponent(new Line(p1, p3));
            AddComponent(new Line(p1, p4));
            AddComponent(new Line(p1, p5));
            AddComponent(new Line(p2, p6));
            AddComponent(new Line(p2, p7));
            AddComponent(new Line(p2, p8));

        }
    }
}
