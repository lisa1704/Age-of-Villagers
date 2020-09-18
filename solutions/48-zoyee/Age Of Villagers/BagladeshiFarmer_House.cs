using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    class BagladeshiFarmer_House : CompositeShape
    {
        public BagladeshiFarmer_House(Point top, Point topleft, Point bottomright)
        {
            AddComponent(new Rectangle(topleft, bottomright));
            AddComponent(new Triangle(top, topleft, new Point(bottomright.X, topleft.Y)));
        }
    }
}
