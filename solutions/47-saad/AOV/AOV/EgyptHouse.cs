using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class EgyptHouse : CompoundShape
    {
        public EgyptHouse(Point clicked)
        {
            Point x1 = new Point(clicked.X - 28, clicked.Y + 50);
            Point x2 = new Point(clicked.X + 16, clicked.Y + 60);
            Point x3 = new Point(clicked.X + 35, clicked.Y + 40);

            addShape(new Triangle(x2, x1, clicked));
            addShape(new Triangle(x3, x2, clicked));
        }
    }
}
