using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class InuitHuntersHouse : CompositeShape
    {
       

        public InuitHuntersHouse(Point point)
        {
            addShape(new BaseArc(point, 40, 40,0,-180));


           

            addShape(new BaseLine(new Point(point.X, point.Y + 20), new Point(point.X + 40, point.Y + 20)));
        
        
        }
    }
}
