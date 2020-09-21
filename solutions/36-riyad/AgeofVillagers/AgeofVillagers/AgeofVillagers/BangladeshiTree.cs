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
            /*Point bottomRight = new Point(mid.X + 8, mid.Y + 24);
            Point top = new Point(mid.X + 16, mid.Y + 18);
            Point topLeft = new Point(mid.X + 6, mid.Y + 12);*/

            Point topRight = new Point(MPt.X + 20, MPt.Y);
            Point bottomRight = new Point(MPt.X + 25, MPt.Y + 50);
            Point topPt = new Point(MPt.X + 40, MPt.Y + 40);
            Point RTopLeft = new Point(MPt.X + 20, MPt.Y + 20);

            AddComponents(new RectangleShape(RTopLeft, bottomRight));
            AddComponents(new EllipseShape(MPt, topPt));


            /*AddComponents(new RectangleShape(topLeft, bottomRight));
            AddComponents(new EllipseShape(mid, top));*/
        }
    }
}
