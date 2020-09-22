using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class InuitHouse : CompositeShape
    {
        public InuitHouse(Point point)
        {
            Point p1 = new Point(point.X - 35, point.Y - 35);
            Point p2 = new Point(point.X - 5, point.Y - 5);
            Point p3 = new Point(point.X - 35, point.Y);
            Point p4 = new Point(point.X + 35, point.Y);
            AddComponent(new Line(p3, p4));
            AddComponent(new Arc(point.X - 5, point.Y - 5, 10, 10, 180.0F, 180.0F));
            AddComponent(new Arc(point.X - 35, point.Y - 35, 70, 70, 180.0F, 180.0F));

        }
    }
}
