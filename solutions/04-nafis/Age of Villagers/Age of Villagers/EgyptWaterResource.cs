using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class EgyptWaterResource:CompositeShape
    {
        Point point;

        public EgyptWaterResource(Point point)
        {
            this.point = point;
            ShapePush(new Arc(point, 10, 10, 0, 180));
            ShapePush(new Arc(point, 10, 10, 0, -180));
        }

    }
}
