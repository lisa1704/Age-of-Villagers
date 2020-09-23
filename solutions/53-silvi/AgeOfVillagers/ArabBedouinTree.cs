using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianKingsTree : Composite
    {
        public EgyptianKingsTree(Point point)
        {
            Point point1 = new Point(point.X + 5, point.Y - 24);
            Point point2 = new Point(point.X - 5, point.Y - 22);
            Point point3 = new Point(point.X + 3, point.Y - 12);
            Point point4 = new Point(point.X + 8, point.Y - 23);
            Point point5 = new Point(point.X + 1, point.Y - 24);
            Point point6 = new Point(point.X - 3, point.Y - 12);
            Point point7 = new Point(point.X - 8, point.Y - 22);
            Point point8 = new Point(point.X - 2, point.Y - 24);

            AddComponent(new Line(point, point1));
            AddComponent(new Line(point, point2));
            AddComponent(new Line(point3, point4));
            AddComponent(new Line(point3, point5));
            AddComponent(new Line(point6, point7));
            AddComponent(new Line(point6, point8));
        }
    }
}
