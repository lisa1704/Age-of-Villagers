using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class ArabHouse:CompositeShape
    {
        public ArabHouse(Point pt)
        {
            Point bottomRight = new Point(pt.X + 10, pt.Y);
            Point top = new Point(pt.X + 5, pt.Y - 13);
            Point rec1 = new Point(pt.X + 16, pt.Y - 3);
            Point rec2 = new Point(pt.X + 11, pt.Y - 15);

            AddComponent(new Triangle(pt, bottomRight, top));
            AddComponent(new Rectangle(top, bottomRight, rec1, rec2));
        }
    }
}
