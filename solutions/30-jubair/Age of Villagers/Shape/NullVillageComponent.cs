using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_of_Villagers.Shape
{
    public class NullVillageComponent : CompositeShape
    {
        private readonly Point _point;

        public NullVillageComponent(Point point)
        {
            _point = point;
        }


    }
}
