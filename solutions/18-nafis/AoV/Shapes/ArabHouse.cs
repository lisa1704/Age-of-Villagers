using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AoV.Shapes
{
    class ArabHouse : ComposeShape
    {
        public ArabHouse(Point clickPoint)
        {
            Point p1 = new Point(clickPoint.X - 24, clickPoint.Y + 50);
            Point p2 = new Point(clickPoint.X + 16, clickPoint.Y + 50);
            Point p3 = new Point(clickPoint.X + 25, clickPoint.Y - 30);
            Point p4 = new Point(p2.X + 25, p2.Y - 30);


            AddShape(new Triangle(p2, p1, clickPoint));
            AddShape(new Line(p3, clickPoint));
            AddShape(new Line(p2, p4));
            AddShape(new Line(p3, p4));
        }
    }
}
