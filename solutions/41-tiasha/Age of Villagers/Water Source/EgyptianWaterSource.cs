using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class EgyptianWaterSource : CompositeShape
    {
        public EgyptianWaterSource(Point p, ElementSize sz)
        {
            AddComponent(new Arc(p.X, p.Y, sz.width, sz.height, 0, 360));
        }
    }
}
