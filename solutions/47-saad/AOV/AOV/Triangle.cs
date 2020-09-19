using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class Triangle : CompoundShape
    {
        public Triangle(Point x, Point y, Point z)
        {
            addShape(new DrawLine(x, y));
            addShape(new DrawLine(y, z));
            addShape(new DrawLine(z, x));
        }
    }
}
