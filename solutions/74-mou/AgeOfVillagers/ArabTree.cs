using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class ArabTree : CompositeShapes
    {
        private Point ptr, pbl, pbr, p1, p2, p3, p4, p5;
        int pm, m, n;
        public ArabTree(Point p)
        {
            ptr = new Point(p.X + 5, p.Y);
            pbr = new Point(p.X + 5, p.Y + 15);
            pbl = new Point(p.X, p.Y + 15);

            m = (p.X + ptr.X) / 2;
            n = (p.Y + ptr.Y) / 2;

            p1 = new Point(m, n - 18);
            p2 = new Point(m + 8, n - 18);
            p3 = new Point(ptr.X + 15, ptr.Y - 12);
            p4 = new Point(m - 8, n - 15);
            p5 = new Point(p.X - 12, p.Y - 12);


            
            Point pm = new Point(m, n);
            add_shapes(new Rectangle(p, pbl, pbr, ptr));
            add_shapes(new Line(pm, p1));
            add_shapes(new Line(pm, p2));
            add_shapes(new Line(pm, p3));
            add_shapes(new Line(pm, p4));
            add_shapes(new Line(p, p5));

        }
    }
}
