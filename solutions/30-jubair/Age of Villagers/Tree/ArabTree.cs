using Age_of_Villagers.Shape;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_of_Villagers.Tree
{
    public class ArabTree : CompositeShape

    {
        public ArabTree(Point startPoint,Point pt1,Point pt3,Point pt2, Point pt4,Point pt5,Point topLeftRectangle,Point bottomRightRectangle)
        {
            AddComponent(new Line(startPoint, pt1));
            AddComponent(new Line(startPoint, pt2));
            AddComponent(new Line(startPoint, pt3));
            AddComponent(new Line(startPoint, pt4));
            AddComponent(new Line(startPoint, pt5));

            // Rectangle
            AddComponent(new MyRectangle(topLeftRectangle, bottomRightRectangle));

        }
    }
}
