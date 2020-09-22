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
            Point x1 = new Point(clicked.X , clicked.Y);
            Point x2 = new Point(x1.X + 16, clicked.Y);
            Point x3 = new Point(x1.X + 16, clicked.Y + 16);
            Point x4 = new Point(x1.X , clicked.Y + 16);

            addShape(new DrawLine(x3, x4));
            addShape(new DrawArc(x1.X, x1.Y, 16, 30, 0, -180));
            addShape(new DrawArc(x1.X + 6, x2.Y + 10, 4, 10, 0, -180));
            //Check
            //addShape(new Rectangle(x1, x3)); //Uncomment to check the height and width
        }
    }
}
