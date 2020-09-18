using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Rectangle : IShapes
    {
        private Point p1, p2, p3,p4;
        private CompositeShapes compSh = new CompositeShapes();
        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        public void generate_rectangle()
        {
            compSh.add_shapes(new Line(p1, p2));
            compSh.add_shapes(new Line(p2, p3));
            compSh.add_shapes(new Line(p3, p4));
            compSh.add_shapes(new Line(p4, p1));

        }
        public void draw_shapes(Graphics gr, Pen pen)
        {
            this.generate_rectangle();
            compSh.draw_shapes(gr, pen);
        }
    }
}
