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
            Point TopPoint = new Point(point.X+60, point.Y+70);
            Point BottomRight = new Point(point.X+28, point.Y+100);
            Point TopLeft = new Point(point.X+33, point.Y+45);

            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Ellipse(point, TopPoint));
        }
    }
}
