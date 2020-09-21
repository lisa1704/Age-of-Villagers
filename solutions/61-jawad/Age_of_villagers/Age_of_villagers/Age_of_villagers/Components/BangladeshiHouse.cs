using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Age_of_villagers.Shapes;

namespace Age_of_villagers.Components
{
    class BangladeshiHouse : VillageComponent
    {
        private readonly Point top, midLeft, midRight, bottomLeft, bottomRight;

        public BangladeshiHouse(Point point)
        {
            top = point;
            midLeft = new Point(top.X - 10, top.Y + 20);
            midRight = new Point(top.X + 10, top.Y + 20);
            bottomRight = new Point(top.X + 10, top.Y + 40);
            AddComp(new Triangle(top, midLeft, midRight));
            AddComp(new Shapes.Rectangle(midLeft, bottomRight));
        }
    }
}
