using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class Ellipse : CompoundShape
    {
        private Point x1;
        private Point x2;
        float height;
        float width;

        public Ellipse(Point x1,Point x2)
        {
            this.x1 = x1;
            this.x2 = x2;
            height = x2.X - x1.X;
            width = x2.Y - x1.Y;
            addShape(new DrawArc(x1.X, x1.Y, height, width, 0, 360));
        }
    }
}
