using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class EgyptianWaterSource : CompositeShape
    {
        public EgyptianWaterSource(Point p)
        {
            Point p1 = new Point(p.X + 60, p.Y + 60);
            AddComponent(new Ellipse(p, p1));
        }
    }
}
