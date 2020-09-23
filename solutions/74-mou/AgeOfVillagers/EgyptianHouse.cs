using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianHouse : CompositeShapes
    {
        Point p1, p2, p3, p4, p5;


        public EgyptianHouse(Point p)
        {
            p1 = p;
            p2 = new Point(p1.X - 15, p1.Y + 45);
            p3 = new Point(p1.X + 15, p1.Y + 30);
            p4 = new Point(p3.X, p2.Y);
            p5 = new Point(p4.X + 5, p4.Y - 30);

            add_shapes(new Triangle(p1, p2, p4));

            add_shapes(new Line(p4, p5));
            add_shapes(new Line(p5, p1));

        }

    }
}
