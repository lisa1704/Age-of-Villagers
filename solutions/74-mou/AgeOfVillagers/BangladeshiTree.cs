using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BangladeshiTree : CompositeShapes
    {
        private Point p1, p2, p3, p4, p5;
        public BangladeshiTree(Point p)
        {
            add_shapes(new Circle(p, 25));
            this.p1 = p;
            p2 = new Point(p1.X + 9, p1.Y + 25);
            p3 = new Point(p2.X, p2.Y + 20);
            p4 = new Point(p2.X + 5, p2.Y + 20);
            p5 = new Point(p2.X + 5, p2.Y);

            
            add_shapes(new Rectangle(p2, p3, p4, p5));

        }
    }
}
