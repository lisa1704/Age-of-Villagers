using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.VillegeItems
{
    class ArabianHouse : VillageItem
    {
        private readonly Point triangleTop, quadTop, bottomLeft, bottomMid, bottomRight;

        public ArabianHouse(Point point)
        {
            triangleTop = point;
            quadTop = new Point(triangleTop.X + 20, triangleTop.Y - 5);
            bottomLeft = new Point(triangleTop.X - 20, triangleTop.Y + 40);
            bottomMid = new Point(triangleTop.X + 20, triangleTop.Y + 40);
            bottomRight = new Point(triangleTop.X + 40, triangleTop.Y + 35);
            addItem(new Triangle(triangleTop, bottomLeft, bottomMid));
            addItem(new Line(triangleTop, quadTop));
            addItem(new Line(bottomRight, quadTop));
            addItem(new Line(bottomMid, bottomRight));
        }
    }
}
