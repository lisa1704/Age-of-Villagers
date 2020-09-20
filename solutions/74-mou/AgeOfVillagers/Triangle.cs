using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Triangle : CompositeShapes
    {
        private Point p1, p2, p3;
        public Triangle(Point p1,Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            add_shapes(new Line(p1, p2));
            add_shapes(new Line(p2, p3));
            add_shapes(new Line(p3, p1));
        }

    }
}
