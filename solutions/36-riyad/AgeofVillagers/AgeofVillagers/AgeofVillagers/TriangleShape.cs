using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class TriangleShape : CompositeShape
    {
        public TriangleShape(Point pt1, Point pt2, Point pt3)
        {
            AddComponents(new LineShape(pt1, pt2));
            AddComponents(new LineShape(pt2, pt3));
            AddComponents(new LineShape(pt1, pt3));
        }
    }
}
