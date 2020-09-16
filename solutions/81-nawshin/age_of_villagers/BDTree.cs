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
            Point topLeft = new Point(pt.X - 2, pt.Y+1);
            Point bottomRight = new Point(pt.X , pt.Y + 15);

            AddComponent(new Arc(pt, 16, 18, 0, 360));
            AddComponent(new Rectangle(topLeft, bottomRight));
        }
    }
}
