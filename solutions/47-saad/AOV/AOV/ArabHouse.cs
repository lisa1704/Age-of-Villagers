using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class ArabHouse : CompoundShape
    {
        public ArabHouse(Point clicked)
        {
            Point x1 = new Point(clicked.X - 30, clicked.Y + 50);
            Point x2 = new Point(clicked.X + 30, clicked.Y + 50);
            Point x3 = new Point(clicked.X + 25, clicked.Y - 30);
            Point x4 = new Point(x2.X + 25, x2.Y - 30);


            addShape(new Triangle(x1, x2, clicked));
            addShape(new DrawLine(x3, clicked));
            addShape(new DrawLine(x2, x4));
            addShape(new DrawLine(x3, x4));
        }
    }
}
