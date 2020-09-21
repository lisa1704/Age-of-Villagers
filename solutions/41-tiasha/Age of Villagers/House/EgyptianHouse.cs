using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class EgyptianHouse : CompositeShape
    {
       

        public EgyptianHouse(Point p, ElementSize sz)
        {
            Point top = p;
            Point bottomMid = new Point(p.X + sz.width / 4, p.Y + sz.height);
            Point bottomleft = new Point(bottomMid.X - sz.width * 10 / 16, p.Y + sz.height - sz.height / 4);
            Point bottomRight = new Point(bottomMid.X + sz.width * 6 / 16, p.Y + (sz.height / 2));



            AddComponent(new Triangle(top, bottomMid, bottomleft));
            AddComponent(new Triangle(top, bottomMid, bottomRight));



        }
    }
}
