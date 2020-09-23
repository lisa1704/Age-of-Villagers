using age_of_villagers.shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers.villageitem
{
    public class bangladeshihouse : villageitem
    {
        private readonly Point top, midLeft, midRight, bottomLeft, bottomRight;

        public bangladeshihouse(Point point)
        {
            top = point;
            midLeft = new Point(top.X - 10, top.Y + 20);
            midRight = new Point(top.X + 10, top.Y + 20);
            bottomRight = new Point(top.X + 10, top.Y + 40);
            Additem(new shape.triangle(top, midLeft, midRight));
            Additem(new shape.rectangle(midLeft, bottomRight));
        }
    }
}
