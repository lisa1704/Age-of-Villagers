using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Bangladeshi_Farmers
{
    public class BDFarmersHouse : Composite
    {
        public BDFarmersHouse(Point point)
        {
            Point Top = new Point(point.X, point.Y);
            Point TopLeft = new Point(point.X - 10, point.Y + 10);
            Point BottomRight = new Point(point.X + 10, point.Y + 20);
            Point TopRight = new Point(BottomRight.X, TopLeft.Y);

            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Triangle(Top, TopLeft, TopRight));
        }
    }
}
