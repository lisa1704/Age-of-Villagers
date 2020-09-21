using Age_of_Villagers.Shape;
using Age_of_Villagers.VillageComponents;
using System;
using System.Drawing;
using Rectangle = Age_of_Villagers.Shape.Rectangle;

namespace AgeOfVillagers.VillegeItems
{

    class BangladeshiHouse : VillageComponents
    {
        private readonly Point top, midLeft, midRight, bottomLeft, bottomRight;

        public BangladeshiHouse(Point point)
        {
            top = point;
            midLeft = new Point(top.X - 10, top.Y + 20);
            midRight = new Point(top.X + 10, top.Y + 20);
            //bottomLeft = new Point(top.X-10, top.Y+40);
            bottomRight = new Point(top.X + 10, top.Y + 40);
            addComponent(new Triangle(top, midLeft, midRight));
            addComponent(new Rectangle(midLeft, bottomRight));
        }

        
    }
}
