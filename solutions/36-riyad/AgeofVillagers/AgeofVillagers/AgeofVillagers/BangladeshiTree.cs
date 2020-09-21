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
            Point topPt = new Point(mid.X + 16, mid.Y + 18);
            Point RTopLeft = new Point(mid.X + 6, mid.Y + 12);

            AddComponents(new RectangleShape(RTopLeft, bottomRight));
            AddComponents(new EllipseShape(mid, topPt));

        }
    }
}
