using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class BangladeshiHouse : CompositeShape
    {
        public BangladeshiHouse(Point top, Point leftTop, Point RightBottom)
        {
            AddComponents(new RectangleShape(leftTop, RightBottom));
            AddComponents(new TriangleShape(top, leftTop, RightBottom));
        }
    }
}
