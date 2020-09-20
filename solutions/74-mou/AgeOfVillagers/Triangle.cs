using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Triangle : IShapes
    {
        private Point p1, p2, p3;
        private CompositeShapes compSh = new CompositeShapes();
        public Triangle(Point p1,Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public void generate_triangle()
        {
            compSh.add_shapes(new Line(p1, p2));
            compSh.add_shapes(new Line(p2, p3));
            compSh.add_shapes(new Line(p3, p1));

        }
        public void DrawShapes(Graphics gr, Pen pen)
        {
            this.generate_triangle();
            compSh.DrawShapes(gr, pen);
        }
    }
}
