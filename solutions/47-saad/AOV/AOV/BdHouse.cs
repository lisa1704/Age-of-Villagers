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
        public BdHouse(Point head, Point x1,Point x3)
        {
            x1.Y = x1.Y + 25;
            addShape(new Rectangle(x1, x3));
            addShape(new Triangle(head, x1, new Point(x3.X, x1.Y)));
        }
    }
}
