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
            Point Rectangle1 = new Point(Initialpoint.X - 40, Initialpoint.Y + 40);
            Point Rectangle2 = new Point(Initialpoint.X + 40, Initialpoint.Y + 80);
            Point Triangle = new Point(Initialpoint.X + 40, Initialpoint.Y + 40);

            addShape(new Rectangle(Rectangle1, Rectangle2));
            addShape(new Triangle(Initialpoint, Rectangle1, Triangle));
        }
    }
}
