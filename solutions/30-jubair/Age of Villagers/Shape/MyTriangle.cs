using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_of_Villagers.Shape
{
   public class MyTriangle : CompositeShape
    {
        public MyTriangle(Point top, Point baseLeft, Point baseRight)
        {
            AddComponent(new Line(top, baseLeft));
            AddComponent(new Line(baseLeft, baseRight));
            AddComponent(new Line(baseRight, top));
        }
    }
}
