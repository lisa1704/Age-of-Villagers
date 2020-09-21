using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class BdHouse : CompoundShape
    {
        public BdHouse(Point clicked)
        {
            int baseLine = clicked.Y + 8;

            Point x1 = new Point(clicked.X - 8, baseLine);
            Point x2 = new Point(clicked.X + 8, baseLine);
            Point bottomRightCorner = new Point(clicked.X + 8, x2.Y + 8);

            addShape(new Rectangle(x1, bottomRightCorner));
            addShape(new Triangle(clicked, x1, x2));
        }
    }
}
