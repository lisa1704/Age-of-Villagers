using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class InuitHouse : CompositeShape
    {
        public InuitHouse(Point p, ElementSize sz)
        {
            Point left = new Point(p.X, p.Y + sz.width / 2);
            Point right = new Point(p.X + sz.width, p.Y + sz.width / 2);
        }
    }
}


