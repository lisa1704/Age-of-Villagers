using Age_of_Villagers.Shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.House
{
   public class BangladeshiHouse : CompositeShape
    {
        public BangladeshiHouse(Point top, Point baseTopLeft, Point baseBottomRight)
        {
            AddComponent(new MyTriangle(top, baseTopLeft, new Point(baseBottomRight.X, baseTopLeft.Y)));
            AddComponent(new MyRectangle(baseTopLeft, baseBottomRight));
           
        }
    }
}
