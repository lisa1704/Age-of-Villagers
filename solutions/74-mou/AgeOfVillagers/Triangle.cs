using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Triangle : CompositeShapes
    {
        public Triangle(Point p1,Point p2, Point p3)
        {
            add_shapes(new Line(p1, p2));
            add_shapes(new Line(p2, p3));
            add_shapes(new Line(p3, p1));
        }

    }
}
