using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AoV.Shapes
{
    class EgyptianHouse : ComposeShape
    {
        public EgyptianHouse(Point clickPoint)
        {
            Point p1 = new Point(clickPoint.X - 24, clickPoint.Y + 50);
            Point p2 = new Point(clickPoint.X + 16, clickPoint.Y + 50);
            Point p3 = new Point(clickPoint.X + 35, clickPoint.Y + 40);


            AddShape(new Triangle(p2, p1, clickPoint));
            AddShape(new Triangle(p3, p2, clickPoint));
        }
    }
}
