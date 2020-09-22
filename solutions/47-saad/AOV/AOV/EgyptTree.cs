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
            Point x1 = new Point(clicked.X, clicked.Y);
            Point x2 = new Point(clicked.X - 4, clicked.Y - 16);
            Point x3 = new Point(clicked.X-8 , clicked.Y - 20);
            Point x4 = new Point(clicked.X - 5, clicked.Y - 22);
            Point x5 = new Point(clicked.X - 1, clicked.Y - 24);
            Point x6 = new Point(clicked.X + 4, clicked.Y - 12);
            Point x7 = new Point(clicked.X + 2, clicked.Y - 24);
            Point x8 = new Point(clicked.X + 8, clicked.Y - 24);
            Point x9 = new Point(clicked.X + 8, clicked.Y - 16);

            addShape(new DrawLine(x1, x4));
            addShape(new DrawLine(x2, x3));
            addShape(new DrawLine(x2, x5));
            addShape(new DrawLine(x1, x8));
            addShape(new DrawLine(x6, x7));
            addShape(new DrawLine(x6, x9));
        }
    }
}
