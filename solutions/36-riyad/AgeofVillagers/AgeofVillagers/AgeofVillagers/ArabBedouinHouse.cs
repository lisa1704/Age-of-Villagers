using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class ArabBedouinHouse : CompositeShape
    {
        public ArabBedouinHouse(Point mid)
        {
            Point tpt1 = new Point(mid.X - 6, mid.Y + 10);
            Point tpt2 = new Point(mid.X + 6, mid.Y + 10);
            Point rpt1 = new Point(tpt2.X + 10, tpt2.Y - 4);
            Point rpt2 = new Point(mid.X + 8, mid.Y - 6);

            AddComponents(new TriangleShape(tpt2, tpt1, mid));
            AddComponents(new RectangleShape(mid, rpt1, tpt2, rpt2));
        }

    }
}
