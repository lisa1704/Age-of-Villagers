using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BDFarmersHouse : Composite
    {
        public BDFarmersHouse(Point Top, Point TopLeft, Point BottomRight)
        {
            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Triangle(Top, TopLeft, new Point(BottomRight.X, TopLeft.Y)));
        }
    }
}
