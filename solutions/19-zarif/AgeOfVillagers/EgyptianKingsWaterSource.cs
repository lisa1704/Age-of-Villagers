using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianKingsWaterSource : CompositeShape 
    {
        private Point _point;

        public EgyptianKingsWaterSource(Point point)
        {
            _point = point;
            addShape(new BaseCircle(point, 12, 12));
        }

        

        
    }
}
