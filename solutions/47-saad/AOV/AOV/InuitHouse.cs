using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class InuitHouse : CompoundShape
    {
        public InuitHouse(Point clicked)
        {
            Point x1 = new Point(clicked.X - 50, clicked.Y+50);
            Point x2 = new Point(clicked.X + 30, clicked.Y+50);
            int innerArc = x1.X + 25;

            addShape(new DrawLine(x1, x2));
            addShape(new DrawArc(x1.X, x2.Y-50, 80, 100, 0, -180));
            addShape(new DrawArc(innerArc, x2.Y - 25, 30, 50, 0, -180));
        }
    }
}
