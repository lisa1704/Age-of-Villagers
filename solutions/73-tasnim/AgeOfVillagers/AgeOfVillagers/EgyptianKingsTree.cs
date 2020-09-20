using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianKingsTree : AbstractShape
    {
        public EgyptianKingsTree(Point Initialpoint)
        {
            Point point1 = new Point(Initialpoint.X + 25, Initialpoint.Y - 50);
            Point point2 = new Point(Initialpoint.X - 25, Initialpoint.Y - 50);
            Point point3 = new Point(Initialpoint.X + 15, Initialpoint.Y - 30);
            Point point4 = new Point(Initialpoint.X + 40, Initialpoint.Y - 45);
            Point point5 = new Point(Initialpoint.X + 10, Initialpoint.Y - 50);
            Point point6 = new Point(Initialpoint.X - 16, Initialpoint.Y - 30);
            Point point7 = new Point(Initialpoint.X - 10, Initialpoint.Y - 50);
            Point point8 = new Point(Initialpoint.X - 35, Initialpoint.Y - 50);

            addShape(new Line(Initialpoint, point1));
            addShape(new Line(Initialpoint, point2));
            addShape(new Line(point3, point4));
            addShape(new Line(point3, point5));
            addShape(new Line(point6, point7));
            addShape(new Line(point6, point8));
        }
    }
}

