using Age_of_Villagers.Shape;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_of_Villagers.House
{
    class EgyptianHouse : CompositeShape
    {
        public EgyptianHouse(Point top, Point mediumLeft, Point bottom, Point mediumRight)
        {
            
            AddComponent(new Line(top, mediumLeft));
            AddComponent(new Line(mediumLeft, bottom));
            AddComponent(new Line(bottom, mediumRight));
            AddComponent(new Line(mediumRight, top));
            AddComponent(new Line(top, bottom));


        }

    }
}
