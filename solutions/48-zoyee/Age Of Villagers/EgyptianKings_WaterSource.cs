using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    class EgyptianKings_WaterSource : CompositeShape
    {
        public EgyptianKings_WaterSource(Point mainPoint)
        {
            Point topPoint = new Point(mainPoint.X + 75, mainPoint.Y + 75);
            AddComponent(new ElipseShape(mainPoint, topPoint));
        }
    }
}
