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
            Point TopPoint = new Point(point.X+80, point.Y+90);
            Point BottomRight = new Point(point.X+36, point.Y+140);
            Point TopLeft = new Point(point.X+42, point.Y+60);

            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Ellipse(point, TopPoint));
        }
    }
}
