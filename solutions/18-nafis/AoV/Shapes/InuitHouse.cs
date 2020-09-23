using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AoV.Shapes
{
    class InuitHouse : ComposeShape
    {

        public InuitHouse(Point clickPoint)
        {
            Point p1 = new Point(clickPoint.X - 50, clickPoint.Y + 40);
            Point p2 = new Point(clickPoint.X + 50, clickPoint.Y + 40);
            Point arc1 = new Point(clickPoint.X - 50, clickPoint.Y);
            Point arc2 = new Point(clickPoint.X + 50, clickPoint.Y);

            AddShape(new Line(p1, p2));
            AddShape(new Arc(arc1.X, arc2.Y, 80, 100, 0, -180));
            AddShape(new Arc(arc1.X + 25, arc2.Y + 25, 30, 50, 0, -180));
        }

    }
}
