using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class Rectangle : CompoundShape
    {
        private Point a;
        private Point b;
        private Point c;
        private Point d;

        public Rectangle(Point a, Point b, Point c, Point d)
        {
            addShape(new DrawLine(a,d));
            addShape(new DrawLine(a, b));
            addShape(new DrawLine(c, d));
            addShape(new DrawLine(b, c));
        }

    }
}
