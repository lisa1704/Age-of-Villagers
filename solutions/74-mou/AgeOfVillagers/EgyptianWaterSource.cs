using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianWaterSource : CompositeShapes
    {
        public EgyptianWaterSource(Point p)
        {
           
            add_shapes(new Circle(p, 35));
        }
    }
}
