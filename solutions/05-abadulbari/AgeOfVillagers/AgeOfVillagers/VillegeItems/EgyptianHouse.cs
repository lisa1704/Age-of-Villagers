using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.VillegeItems
{
    class EgyptianHouse : VillageItem
    {
        private readonly Point top, bottomLeft, bottomMid, bottomRight;

        public EgyptianHouse(Point point)
        {
            top = point;
            bottomLeft = new Point(top.X - 40, top.Y + 35);
            bottomMid = new Point(top.X + 5, top.Y + 60);
            bottomRight = new Point(top.X + 25, top.Y + 30);
            addItem(new Line(top, bottomLeft));
            addItem(new Line(top, bottomMid));
            addItem(new Line(top, bottomRight));
            addItem(new Line(bottomLeft, bottomMid));
            addItem(new Line(bottomMid, bottomRight));
        }
    }
}
