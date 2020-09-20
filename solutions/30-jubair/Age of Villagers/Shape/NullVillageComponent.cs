using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_of_Villagers.Shape
{
    public class NullVillageComponent : CompositeShape
    {
        Point point = new Point();

        public NullVillageComponent(Point point)
        {
            this.point= point;
        }

        public Point DrawNothing()
        {
            return point;
        }


    }
}
