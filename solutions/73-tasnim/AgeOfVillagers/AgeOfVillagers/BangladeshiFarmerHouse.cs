using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BangladeshiFarmerHouse : AbstractShape
    {
        public BangladeshiFarmerHouse(Point top, Point topleft, Point bottomright)
        {
            Point topright = new Point(bottomright.X, topleft.Y);
            addShape(new Rectangle(topleft, bottomright));
            addShape(new Triangle(top, topleft, topright ));
        }
    }
}
