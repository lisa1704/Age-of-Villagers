using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class BangladeshiWaterResource : CompositeShape
    {
        public BangladeshiWaterResource(Point mid)
        {
            Point pt1 = new Point(mid.X - 8, mid.Y + 6);
            Point pt2 = new Point(mid.X - 12, mid.Y + 14);
            Point pt3 = new Point(mid.X - 6, mid.Y + 20);
            Point pt4 = new Point(mid.X + 6, mid.Y + 16);
            Point pt5 = new Point(mid.X + 14, mid.Y + 20);
            Point pt6 = new Point(mid.X + 20, mid.Y + 11);
            Point pt7 = new Point(mid.X + 12, mid.Y);
            Point pt8 = new Point(mid.X + 6, mid.Y + 8);

            AddComponents(new LineShape(mid, pt1));
            AddComponents(new LineShape(pt1, pt2));
            AddComponents(new LineShape(pt2, pt3));
            AddComponents(new LineShape(pt3, pt4));
            AddComponents(new LineShape(pt4, pt5));
            AddComponents(new LineShape(pt5, pt6));
            AddComponents(new LineShape(pt6, pt7));
            AddComponents(new LineShape(pt7, pt8));
            AddComponents(new LineShape(mid, pt8));

        }
    }
}
