using Age_of_Villagers.Shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.VillageComponents
{
    class EgyptianWaterSource : VillageComponents
    {
        private readonly Point topLeft, bottomRight;

        public EgyptianWaterSource(Point point)
        {
            topLeft = new Point(point.X - 6, point.Y - 6);
            bottomRight = new Point(point.X + 6, point.Y + 6);
            addComponent(new Arc(topLeft, bottomRight));
        }

     
    }
}
