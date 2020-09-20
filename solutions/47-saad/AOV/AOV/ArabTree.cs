using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class ArabTree : CompoundShape
    {
        public ArabTree(Point clicked)
        {
            Point topLeftCorner = new Point(clicked.X, clicked.Y);
            Point bottomRightCorner = new Point(clicked.X + 6, clicked.Y + 60);
            Point topCenter = new Point(clicked.X+3, clicked.Y);
            Point topRightHalf = new Point(clicked.X+4, clicked.Y);
            Point topRightCorner = new Point(clicked.X + 6, clicked.Y);
            Point topLeftHalf = new Point(clicked.X+2, clicked.Y);
            Point x1 = new Point(clicked.X - 76, clicked.Y - 30);
            Point x2 = new Point(clicked.X - 42, clicked.Y - 50);
            Point x3 = new Point(clicked.X + 3, clicked.Y - 60);
            Point x4 = new Point(clicked.X + 50, clicked.Y - 50);
            Point x5 = new Point(clicked.X + 82, clicked.Y - 30);

            addShape(new Rectangle(topLeftCorner, bottomRightCorner));
            addShape(new DrawLine(topCenter, x3));
            addShape(new DrawLine(topRightHalf, x4));
            addShape(new DrawLine(topRightCorner, x5));
            addShape(new DrawLine(topLeftHalf, x2));
            addShape(new DrawLine(topLeftCorner, x1));
        }
    }
}
