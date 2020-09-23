using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class InuitHouse : CompositeShapes
    {
        Point p1, p2, p3;


        public InuitHouse(Point p)
        {
            add_shapes(new Arc(p, 55, 0, -180));

            p1 = new Point(p.X + 17, p.Y + 18);
            add_shapes(new Arc(p1, 17, 0, -180));

            p2 = new Point(p.X, p.Y + 55 / 2);
            p3 = new Point(p.X + 55, p.Y + 55 / 2);
            add_shapes(new Line(p2, p3));

        }


    }
}
