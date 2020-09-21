using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BangladeshiFarmersHouse : AbstractShape
    {
        public BangladeshiFarmersHouse(Point Initialpoint)
        {
            Point Triangle = new Point(Initialpoint.X + 8, Initialpoint.Y + 8);
            Point RectPoint1 = new Point(Initialpoint.X - 8, Initialpoint.Y + 8);
            Point RectPoint2 = new Point(Initialpoint.X + 8, Initialpoint.Y + 16);

            addShape(new Triangle(Initialpoint, RectPoint1, Triangle));
            addShape(new Rectangle(RectPoint1, RectPoint2));
 
        }
    }
}
