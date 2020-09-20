using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BangladeshiHouse : CompositeShapes
    {
        private Point p1, p2, p3, p4;


        public BangladeshiHouse(Point p)
        {
            this.p1 = p;
            p2 = new Point(p1.X - 10, p1.Y + 10);
            p3 = new Point(p1.X + 10, p1.Y + 20);
            p4 = new Point(p3.X, p2.Y);

            add_shapes(new Triangle(p1, p2, p3));
            add_shapes(new Rectangle(p1, p2, p3, p4));

        }
    }
}
