using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class BDHouse :CompositeShape
    {

        public BDHouse(Point pt)
        {
            //pt=topLeft
            Point topRight = new Point(pt.X + 50, pt.Y);
            Point top = new Point(pt.X+25,pt.Y-25);
            Point bottomRight = new Point(pt.X + 50, pt.Y + 25);
            AddComponent(new Triangle(top, pt, topRight));
            AddComponent(new Rectangle(pt, bottomRight));

        }
    }

}
