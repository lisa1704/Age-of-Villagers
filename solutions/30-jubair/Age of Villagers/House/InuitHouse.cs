using Age_of_Villagers.Shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.House
{
    public class InuitHouse : CompositeShape
    {
        public InuitHouse(Point startPoint,Point pt1)
        {
            AddComponent(new Line(startPoint, pt1));
            AddComponent(new NewArc(startPoint.X, startPoint.Y-16, 16, 32, 180, 180));
            AddComponent(new NewArc(startPoint.X+5, startPoint.Y-6, 6, 12, 180, 180));

        }
    }
}
