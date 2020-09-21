using Age_of_Villagers.Shape;
using Age_of_Villagers.VillageComponents;
using System.Drawing;

namespace AgeOfVillagers.VillegeItems
{
    class EgyptianHouse : VillageComponents
    {
        private readonly Point top, bottomLeft, bottomMid, bottomRight;

        public EgyptianHouse(Point point)
        {
            top = point;
            bottomLeft = new Point(top.X - 40, top.Y + 35);
            bottomMid = new Point(top.X + 5, top.Y + 60);
            bottomRight = new Point(top.X + 25, top.Y + 30);
            addComponent(new Line(top, bottomLeft));
            addComponent(new Line(top, bottomMid));
            addComponent(new Line(top, bottomRight));
            addComponent(new Line(bottomLeft, bottomMid));
            addComponent(new Line(bottomMid, bottomRight));
        }
    }
}
