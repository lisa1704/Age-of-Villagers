using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Bangladeshi_Farmers
{
    public class BDFarmersTree : Composite
    {
        public BDFarmersTree(Point point)
        {
            Point TopPoint = new Point(point.X + 15, point.Y + 20);
            Point TopLeft = new Point(point.X + 6, point.Y + 12);
            Point BottomRight = new Point(point.X + 9, point.Y + 30);

            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Ellipse(point, TopPoint));
        }
    }
}
