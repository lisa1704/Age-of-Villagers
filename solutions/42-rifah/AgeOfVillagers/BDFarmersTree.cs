using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BDFarmersTree : Composite
    {
        public BDFarmersTree(Point point)
        {
            Point TopPoint = new Point(point.X+100, point.Y+90);
            Point BottomRight = new Point(point.X+30, point.Y+150);
            Point TopLeft = new Point(point.X+20, point.Y+20);

            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Ellipse(point, TopPoint));
        }
    }
}
