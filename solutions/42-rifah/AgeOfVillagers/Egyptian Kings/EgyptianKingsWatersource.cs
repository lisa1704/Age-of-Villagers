using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Egyptian_Kings
{
    public class EgyptianKingsWatersource : Composite
    {
        public EgyptianKingsWatersource(Point point)
        {
            Point topPoint = new Point(point.X + 70, point.Y + 70);
            AddComponent(new Ellipse(point, topPoint));
        }
    }
}
