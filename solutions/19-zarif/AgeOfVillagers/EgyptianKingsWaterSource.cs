using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianKingsWaterSource : CompositeShape
    {
        public EgyptianKingsWaterSource(Point point)
        {
            addShape(new BaseCircle(point, 12, 12));
        }
    }
}
