using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class ArabTree : CompositeShapes
    {
        private Point p1, p2, p3, p4, p5;
        public ArabTree(Point p)
        {
            this.p1 = p;
            p2 = new Point(p1.X + 10, p1.Y + 15);
            p3 = new Point(p2.X, p2.Y + 18);
            p4 = new Point(p2.X + 5, p2.Y + 18);
            p5 = new Point(p2.X + 5, p2.Y);

            add_shapes(new Circle(p, 15));
            add_shapes(new Rectangle(p2, p3, p4, p5));

        }
    }
}
