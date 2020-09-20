using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class NullShape : CompoundShape
    {
        public NullShape(Point clicked)
        {
            Point x1 = new Point(clicked.X, clicked.Y);
            addShape(new DrawLine(x1, x1));
        }
    }
}
