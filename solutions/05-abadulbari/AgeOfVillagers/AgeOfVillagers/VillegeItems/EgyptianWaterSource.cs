using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.VillegeItems
{
    class EgyptianWaterSource : VillageItem
    {
        private readonly Point topLeft, bottomRight;

        public EgyptianWaterSource(Point point)
        {
            topLeft = new Point(point.X - 6, point.Y - 6);
            bottomRight = new Point(point.X + 6, point.Y + 6);
            addItem(new Circle(topLeft, bottomRight));
        }
    }
}
