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
            Point bottomRight = new Point(point.X + 36, point.Y + 140);
            Point topLeft = new Point(point.X + 42, point.Y + 60);
            AddComponent(new Rectangle(topLeft, bottomRight));
            AddComponent(new Ellipse(point, topPoint));
           

        }
    }
}
