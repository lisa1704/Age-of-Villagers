using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AoV.Shapes
{
    class BangladeshiHouse : ComposeShape
    {

        private Point p1, p2, p3;

        public BangladeshiHouse(Point clickPoint, Point p1, Point p3)
        {
            AddShape(new Rectangle(p1, p3));
            AddShape(new Triangle(clickPoint, p1, new Point(p3.X, p1.Y)));
        }

    }
}
