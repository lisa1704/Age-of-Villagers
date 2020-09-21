using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class EgyptianKingsTree : CompositeShape
    {
        public EgyptianKingsTree(Point MPt)
        {
            Point L1 = new Point(MPt.X + 6, MPt.Y - 22);
            Point L2 = new Point(MPt.X - 7, MPt.Y - 23);

            Point RTopLeft = new Point(MPt.X, MPt.Y);
            Point point3 = new Point(MPt.X + 4, MPt.Y - 15);
            Point point4 = new Point(MPt.X + 8, MPt.Y - 20);
            Point point5 = new Point(MPt.X + 2, MPt.Y - 20);
            Point point6 = new Point(MPt.X - 4, MPt.Y - 15);
            Point point7 = new Point(MPt.X - 2, MPt.Y - 22);
            Point point8 = new Point(MPt.X - 8, MPt.Y - 20);

            AddComponents(new LineShape(RTopLeft, L1));
            AddComponents(new LineShape(RTopLeft, L2));
            AddComponents(new LineShape(point3, point4));
            AddComponents(new LineShape(point3, point5));
            AddComponents(new LineShape(point6, point7));
            AddComponents(new LineShape(point6, point8));
        }
    }
}
