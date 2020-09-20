using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class EgyptTree : CompoundShape
    {
        public EgyptTree(Point clicked)
        {
            int level = clicked.Y - 50;

            Point x1 = new Point(clicked.X, clicked.Y);
            Point x2 = new Point(clicked.X - 20, clicked.Y - 30);
            Point x3 = new Point(clicked.X - 40, clicked.Y - 45);
            Point x4 = new Point(clicked.X - 30, level);
            Point x5 = new Point(clicked.X - 15, clicked.Y - 53);
            Point x6 = new Point(clicked.X + 10, clicked.Y - 25);
            Point x7 = new Point(clicked.X + 5, level);
            Point x8 = new Point(clicked.X + 20, level);
            Point x9 = new Point(clicked.X + 35, level);

            addShape(new DrawLine(x1, x4));
            addShape(new DrawLine(x2, x3));
            addShape(new DrawLine(x2, x5));
            addShape(new DrawLine(x1, x8));
            addShape(new DrawLine(x6, x7));
            addShape(new DrawLine(x6, x9));
        }
    }
}
