using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class EgyptHouse:CompositeShape
    {
        public EgyptHouse(Point pt)
        {
            //pt=bottomLeft
            Point bottomMid = new Point(pt.X+60,pt.Y+15);
            Point top = new Point(pt.X+45,pt.Y-80);
            Point bottomRight = new Point(pt.X + 85, pt.Y - 20);

            AddComponent(new Triangle(pt, top, bottomMid));
            AddComponent(new Triangle(top, bottomMid, bottomRight));

        }
        
    }
}
