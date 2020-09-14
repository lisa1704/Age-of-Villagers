using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class BDTree:CompositeShape
    {
        public BDTree(Point pt)
        {
            Point topLeft = new Point(pt.X - 1, pt.Y);
            Point bottomRight = new Point(pt.X + 1, pt.Y + 50);

            AddComponent(new Arc(pt, 44, 50, 0, 360));
            AddComponent(new Rectangle(topLeft, bottomRight));
        }
    }
}
