using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Age_of_villagers.Shape;
namespace Age_of_villagers.Components
{
    class Bangladeshi_tree : VillageComponent
    {
        private readonly Point tL;
        private readonly Point bR;
        private readonly Point c;


        public Bangladeshi_tree(Point point)
        {
            c = point;
            tL.X = point.X - 20;
            tL.Y = point.Y - 20;
            bR.X = point.X + 20;
            bR.Y = point.Y + 20;
            AddComp(new Arc(tL, bR));
            AddComp(new Shape.Rectangle(new Point(c.X - 2, c.Y), new Point(c.X + 2, c.Y + 40)));
        }
    }
}
