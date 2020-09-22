using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class IunitHuntersHouse : CompositeShape
    {
        public IunitHuntersHouse(Point mid)
        {
            
            Point pt1 = new Point(mid.X - 20, mid.Y + 10);
            Point pt2 = new Point(mid.X + 20, mid.Y + 10);
            Point arpt = new Point(mid.X-5, mid.Y + 7);

            AddComponents(new LineShape(pt1, pt2));
            AddComponents(new Arc(arpt.X, arpt.Y, 10, 4, -4, -180.0F));
            AddComponents(new Arc(pt1.X, pt1.Y - 8, 40, 14, 0, -180.0F));

        }
    }
}
