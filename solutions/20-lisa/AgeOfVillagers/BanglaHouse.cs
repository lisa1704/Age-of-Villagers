using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BanglaHouse : CompositeShape
    {
        public BanglaHouse(Point p)
        {
            Point top = new Point(p.X, p.Y);
            Point topLeft = new Point(p.X - 40, p.Y + 20);
            Point bottomRight = new Point(p.X + 40, p.Y + 70);
            Point topRight = new Point(bottomRight.X, topLeft.Y);
            AddComponent(new Rectangle(topLeft, bottomRight));
            AddComponent(new Triangle(top, topLeft, topRight));
        }
    }
}
