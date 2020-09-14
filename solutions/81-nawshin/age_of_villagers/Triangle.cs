using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using age_of_villagers;

namespace age_of_villagers
{
    public class Triangle:CompositeShape
    {
        public Triangle(Point pt1, Point pt2, Point pt3)
        {
            AddComponent(new Line(pt1, pt2));
            AddComponent(new Line(pt2, pt3));
            AddComponent(new Line(pt3, pt1));

        }

    }
}
