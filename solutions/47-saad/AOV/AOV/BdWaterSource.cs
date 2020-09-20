using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class BdWaterSource : CompoundShape
    {
        public BdWaterSource(Point clicked)
        {
            Point p1 = new Point(clicked.X, clicked.Y);
            Point p2 = new Point(clicked.X + 20, clicked.Y - 10);
            Point p3 = new Point(clicked.X + 25, clicked.Y);
            Point p4 = new Point(clicked.X + 50, clicked.Y - 20);
            Point p5 = new Point(clicked.X + 80, clicked.Y);
            Point p6 = new Point(clicked.X + 70, clicked.Y + 40);
            Point p7 = new Point(clicked.X + 30, clicked.Y + 20);
            Point p8 = new Point(clicked.X, clicked.Y + 50);
            Point p9 = new Point(clicked.X - 20, clicked.Y + 30);

            addShape(new DrawLine(p1, p2));
            addShape(new DrawLine(p2, p3));
            addShape(new DrawLine(p3, p4));
            addShape(new DrawLine(p4, p5));
            addShape(new DrawLine(p5, p6));
            addShape(new DrawLine(p6, p7));
            addShape(new DrawLine(p7, p8));
            addShape(new DrawLine(p8, p9));
            addShape(new DrawLine(p9, p1));

        }
    }
}
