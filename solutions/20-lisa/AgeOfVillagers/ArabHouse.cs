using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class ArabHouse : CompositeShape
    {
        public ArabHouse(Point point)
        {
            Point p1 = new Point(point.X - 20, point.Y + 40);
            Point p2 = new Point(point.X + 20, point.Y + 40);
            Point p3 = new Point(point.X + 25, point.Y - 15);
            Point p4 = new Point(p2.X + 25, p2.Y - 10);

            AddComponent(new Triangle(point, p1, p2));
            AddComponent(new Line(point, p3));
            AddComponent(new Line(p2, p4));
            AddComponent(new Line(p3, p4));
        }
    }
}
