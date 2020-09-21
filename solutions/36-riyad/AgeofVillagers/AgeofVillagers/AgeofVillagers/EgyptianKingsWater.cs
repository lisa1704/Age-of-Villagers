using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class EgyptianKingsWater : CompositeShape
    {
        public EgyptianKingsWater(Point pt)
        {
            Point pt1 = new Point(pt.X + 12, pt.Y + 12);

            AddComponents(new EllipseShape(pt, pt1));
        }
    }
}
