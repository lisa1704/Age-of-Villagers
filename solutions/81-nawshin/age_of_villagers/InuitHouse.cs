using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class InuitHouse:CompositeShape
    {
        public InuitHouse(Point pt)
        {
            Point left = new Point(pt.X - 20, pt.Y);
            Point right = new Point(pt.X + 20, pt.Y);
            Point hc = new Point(pt.X + 5, pt.Y);
            Point inner= new Point(right.X-3 , pt.Y+15);

            AddComponent(new Line(left, right));
            AddComponent(new Arc(hc, 40, 40, -192, 208));
            AddComponent(new Arc(inner, 15, 15, -192, 208));
        }
    }
}
