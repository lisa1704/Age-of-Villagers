using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BanglaTree : CompositeShape
    {
        public BanglaTree(Point point)
        {
            Point topPoint = new Point(point.X + 80, point.Y + 90);
            Point bottomRight = new Point(point.X + 50, point.Y + 120);
            Point topLeft = new Point(point.X + 53, point.Y + 65);
            AddComponent(new Rectangle(topLeft, bottomRight));
            AddComponent(new Ellipse(point, topPoint));
           

        }
    }
}
