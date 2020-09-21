using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Age_of_villagers.Shapes;

namespace Age_of_villagers.Components
{
    class BangladeshiTree : VillageComponent
    {
        private readonly Point topLeft, bottomRight, centre;

        public BangladeshiTree(Point point)
        {
            centre = point;
            topLeft.X = point.X - 20;
            topLeft.Y = point.Y - 20;
            bottomRight.X = point.X + 20;
            bottomRight.Y = point.Y + 20;
            AddComp(new Arc(topLeft, bottomRight));
            AddComp(new Shapes.Rectangle(new Point(centre.X - 2, centre.Y), new Point(centre.X + 2, centre.Y + 40)));
        }
    }
}
