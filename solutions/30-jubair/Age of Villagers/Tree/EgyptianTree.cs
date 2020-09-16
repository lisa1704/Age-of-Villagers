using Age_of_Villagers.Shape;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_of_Villagers.Tree
{
    public class EgyptianTree : CompositeShape
    {
        public EgyptianTree(Point startPoint, Point pt1, Point pt2, Point pt3, Point pt4, Point pt5, Point pt6, Point pt7, Point pt8)
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
