using age_of_villagers.shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers.villageitem
{
    class bangladeshitree : villageitem
    {
        private readonly Point topLeft, bottomRight, centre;

        public bangladeshitree(Point point)
        {
            centre = point;
            topLeft.X = point.X - 20;
            topLeft.Y = point.Y - 20;
            bottomRight.X = point.X + 20;
            bottomRight.Y = point.Y + 20;
            Additem(new shape.arc(topLeft, bottomRight));
            Additem(new shape.rectangle(new Point(centre.X - 2, centre.Y), new Point(centre.X + 2, centre.Y + 40)));
        }
    }
}
