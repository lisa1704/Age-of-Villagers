using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class EgyptWatersource:CompositeShape
    {
        public EgyptWatersource(Point pt)
        {
            AddComponent(new Arc(pt, 12, 12, 0, 360));
        }
    }
}
