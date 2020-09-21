using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class BangladeshiTree : CompositeShape
    {
        public BangladeshiTree(Point MPt)
        {
            Point bottomRight = new Point(MPt.X + 8, MPt.Y + 24);
            Point topPt = new Point(MPt.X + 16, MPt.Y + 18);
            Point RTopLeft = new Point(MPt.X + 6, MPt.Y + 12);

            AddComponents(new RectangleShape(RTopLeft, bottomRight));
            AddComponents(new EllipseShape(MPt, topPt));

        }
    }
}
