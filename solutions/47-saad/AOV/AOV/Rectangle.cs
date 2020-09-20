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
        private Point x1;
        private Point x2;
        private Point x3;
        private Point x4;

        public Rectangle(Point x1, Point x3)
        {
            this.x2 = new Point(x3.X, x1.Y);
            this.x4 = new Point(x1.X, x3.Y);

            addShape(new DrawLine(x1, x4));
            addShape(new DrawLine(x1, x2));
            addShape(new DrawLine(x3, x4));
            addShape(new DrawLine(x2, x3));
        }

    }
}
