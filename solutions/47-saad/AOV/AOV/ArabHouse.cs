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
            int baseLine = clicked.Y + 10;

            Point x1 = new Point(clicked.X - 4, baseLine);
            Point x2 = new Point(clicked.X + 4, baseLine);
            Point x3 = new Point(x2.X + 4, clicked.Y - 6);
            Point x4 = new Point(x3.X + 4, x2.Y - 4);

            addShape(new Triangle(x1, x2, clicked));
            addShape(new DrawLine(x3, clicked));
            addShape(new DrawLine(x2, x4));
            addShape(new DrawLine(x3, x4));
        }
    }
}
