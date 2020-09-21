using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class BangladeshiTree : CompositeShape
    {
        public BangladeshiTree(Point mid)
        {
            Point bottomRight = new Point(mid.X + 8, mid.Y + 24);
            Point top = new Point(mid.X + 16, mid.Y + 18);
            Point topLeft = new Point(mid.X + 6, mid.Y + 12);


            AddComponents(new RectangleShape(topLeft, bottomRight));
            AddComponents(new EllipseShape(mid, top));
        }
    }
}
