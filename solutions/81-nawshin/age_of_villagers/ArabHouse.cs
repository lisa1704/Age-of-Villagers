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
            Point bottomRight = new Point(pt.X + 26, pt.Y);
            Point top = new Point(pt.X + 13, pt.Y - 29);
            Point rec1 = new Point(pt.X + 26, pt.Y - 38);
            Point rec2 = new Point(pt.X + 35, pt.Y - 15);

            AddComponent(new Triangle(pt, bottomRight, top));
            AddComponent(new Rectangle(bottomRight, top, rec1, rec2));
        }
    }
}
