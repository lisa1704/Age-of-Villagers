using System.Drawing;
using Age_of_Villagers.VillageComponents;
using Age_of_Villagers.Shape;

namespace Age_of_villagers.Components
{
    class BangladeshiTree : VillageComponents
    {
        private readonly Point topLeft, bottomRight, centre;
        public BangladeshiTree(Point point)
        {
            centre = point;
            topLeft.X = point.X - 20;
            topLeft.Y = point.Y - 20;
            bottomRight.X = point.X + 20;
            bottomRight.Y = point.Y + 20;
            addComponent(new Arc(topLeft, bottomRight));
            addComponent(new Age_of_Villagers.Shape.Rectangle(new Point(centre.X - 2, centre.Y), new Point(centre.X + 2, centre.Y + 40)));
        }
    }
}