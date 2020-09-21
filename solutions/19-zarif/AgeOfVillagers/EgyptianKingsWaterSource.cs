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
           

            addShape(new BaseArc(point,12,12,0,-180));
            addShape(new BaseArc(point, 12, 12, 0, 180));


        }

        

        
    }
}
