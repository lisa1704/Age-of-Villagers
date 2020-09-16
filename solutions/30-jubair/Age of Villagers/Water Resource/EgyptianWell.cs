using Age_of_Villagers.Shape;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_of_Villagers.Water_Resource
{
    public class EgyptianWell : CompositeShape
    {
        public EgyptianWell (Point pt1, Point pt2)
        {
            AddComponent(new NewEllipse(pt1, pt2));
        }
    }
}
