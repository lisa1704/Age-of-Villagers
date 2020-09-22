using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Egyptian_Tree : CompositeShaping
    {
        public Egyptian_Tree(Point startPoint, Point pt1, Point pt2, Point pt3, Point pt4, Point pt5, Point pt6, Point pt7, Point pt8)
        {
            AddComponent(new Line(startPoint, pt1));
            AddComponent(new Line(startPoint, pt2));
            AddComponent(new Line(pt1, pt3));
            AddComponent(new Line(pt2, pt4));
            AddComponent(new Line(pt1, pt5));
            AddComponent(new Line(pt1, pt6));
            AddComponent(new Line(pt2, pt7));
            AddComponent(new Line(pt2, pt8));

        }
    }
}
