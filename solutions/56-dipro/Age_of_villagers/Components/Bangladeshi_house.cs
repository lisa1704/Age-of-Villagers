using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Age_of_villagers.Shape;


namespace Age_of_villagers.Components
{
    class Bangladeshi_house : VillageComponent
    {
        private readonly Point t, mL, mR, bL, bR;

        public Bangladeshi_house(Point point)
        {
            t = point;
            mL = new Point(t.X - 10, t.Y + 20);
            mR = new Point(t.X + 10, t.Y + 20);
            bR = new Point(t.X + 10, t.Y + 40);
            AddComp(new Triangle(t, mL, mR));
            AddComp(new Shape.Rectangle(mL, bR));
        }
    }
}
