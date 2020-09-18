using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Egyptian_Kings
{
    class EgyptianKingsWatersource : Composite
    {
        public EgyptianKingsWatersource(Point point)
        {
            Point topPoint = new Point(point.X + 100, point.Y + 100);
            AddComponent(new Ellipse(point, topPoint));
        }
    }
}
