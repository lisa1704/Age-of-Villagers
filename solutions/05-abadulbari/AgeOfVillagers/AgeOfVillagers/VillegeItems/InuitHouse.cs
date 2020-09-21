using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.VillegeItems
{
    class InuitHouse : VillageItem
    {
        private readonly Point topLeft, bottomRight;
        public InuitHouse(Point centre)
        {
            topLeft.X = centre.X - 30;
            topLeft.Y = centre.Y - 30;
            bottomRight.X = centre.X + 30;
            bottomRight.Y = centre.Y + 30;
            addItem(new HalfCircle(topLeft, bottomRight));
            addItem(new HalfCircle(new Point(centre.X-10,centre.Y-10), new Point(centre.X+10, centre.Y+10)));
            addItem(new Line(new Point(centre.X-30, centre.Y), new Point(centre.X+30, centre.Y)));
        }
    }
}
