using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Egyptian_WaterSource : CompositeShaping
    {
        public Egyptian_WaterSource(Point pt1, Point pt2)
        {
            AddComponent(new EllipseShape(pt1, pt2));
        }
    }
}
