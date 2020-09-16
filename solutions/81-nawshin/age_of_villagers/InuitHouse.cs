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
            Point left = new Point(pt.X - 5, pt.Y+1);
            Point right = new Point(pt.X + 11, pt.Y+1);
            Point outcircle = new Point(pt.X + 5, pt.Y);
            Point incircle = new Point(pt.X +9, pt.Y+5);

            AddComponent(new Line(left, right));
            AddComponent(new Arc(outcircle, 16, 16, -192, 208));
            AddComponent(new Arc(incircle, 8, 8, -192, 208));
        }
    }
}
