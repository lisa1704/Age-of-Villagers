using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BangladeshiWaterSource : CompositeShapes
    {
        private Point p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;
        public BangladeshiWaterSource(Point p)
        {
            this.p1 = p;
            p2 = new Point(p1.X + 10, p1.Y - 10);
            p3 = new Point(p2.X + 12, p2.Y + 10);
            p4 = new Point(p3.X + 10, p1.Y - 18);
            p5 = new Point(p4.X + 8, p1.Y + 12);
            p6 = new Point(p5.X + 20, p1.Y - 10);
            p7 = new Point(p6.X, p6.Y + 25);
            p8 = new Point(p7.X - 18, p7.Y + 20);
            p9 = new Point(p8.X - 25, p7.Y + 10);
            p10 = new Point(p9.X - 8, p7.Y + 10);

            add_shapes(new Line(p1, p2));
            add_shapes(new Line(p2, p3));
            add_shapes(new Line(p3, p4));
            add_shapes(new Line(p4, p5));
            add_shapes(new Line(p5, p6));
            add_shapes(new Line(p6, p7));
            add_shapes(new Line(p7, p8));
            add_shapes(new Line(p8, p9));
            add_shapes(new Line(p9, p10));
            add_shapes(new Line(p10, p1));



        }
    }
}
