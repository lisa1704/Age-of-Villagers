using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKingWater : CompositeShapes
    {
        
        public EgyptianKingWater(Point point)
        {
            addshapes(new Circle(point, 12, 12));    
        }
        
    }
}
