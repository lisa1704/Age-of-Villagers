using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AoV.Shapes
{
    class EgyptianTree : ComposeShape
    {
        public EgyptianTree(Point clickPoint)
        {
            Point p1 = new Point(clickPoint.X, clickPoint.Y);
            Point p2 = new Point(clickPoint.X + 70, clickPoint.Y + 80);
            Point p3 = new Point(clickPoint.X + 140, clickPoint.Y);
            Point p4 = new Point(clickPoint.X + 13, clickPoint.Y + 15);
            Point p5 = new Point(clickPoint.X + 20, clickPoint.Y - 10);
            Point p6 = new Point(clickPoint.X - 20, clickPoint.Y);
            Point p7 = new Point(clickPoint.X + 120, clickPoint.Y - 20);
            Point p8 = new Point(clickPoint.X + 123, clickPoint.Y + 20);
            Point p9 = new Point(clickPoint.X + 180, clickPoint.Y);

            AddShape(new Line(p1, p2));
            AddShape(new Line(p2, p3));
            AddShape(new Line(p4, p5));
            AddShape(new Line(p4, p6));
            AddShape(new Line(p7, p8));
            AddShape(new Line(p8, p9));

        }
    }
}
