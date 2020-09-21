using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class EgyptianKingsHouse : CompositeShape
    {
        public EgyptianKingsHouse(Point mid)
        {
            Point point1 = new Point(mid.X - 24, mid.Y + 50);
            Point point2 = new Point(mid.X + 16, mid.Y + 50);
            Point point3 = new Point(point2.X + 15, point2.Y - 25);

            AddComponents(new TriangleShape(point2, point1, mid));
            AddComponents(new TriangleShape(point3, point2, mid));
        }
    }
}
