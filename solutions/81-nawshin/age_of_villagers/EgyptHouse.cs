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
            Point bottomMid = new Point(pt.X+10,pt.Y+4);
            Point top = new Point(pt.X + 8, pt.Y - 12);
            Point bottomRight = new Point(pt.X + 16, pt.Y - 3);

            AddComponent(new Triangle(pt, top, bottomMid));
            AddComponent(new Triangle(top, bottomMid, bottomRight));

        }
        
    }
}
