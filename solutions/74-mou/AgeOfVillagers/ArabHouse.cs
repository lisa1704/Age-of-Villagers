using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class ArabHouse : CompositeShapes
    {
        private Point p1, p2, p3, p4, p5;


        public ArabHouse(Point p)
        {
            p1 = p;
            p2 = new Point(p1.X - 20, p1.Y + 20);
            p3 = new Point(p1.X + 20, p2.Y);
            p4 = new Point(p3.X + 15, p3.Y - 12);
            p5 = new Point(p1.X + 15, p1.Y - 12);

            add_shapes(new Triangle(p1, p2, p3));
            add_shapes(new Rectangle(p1, p3, p4, p5));

        }
    }
}
