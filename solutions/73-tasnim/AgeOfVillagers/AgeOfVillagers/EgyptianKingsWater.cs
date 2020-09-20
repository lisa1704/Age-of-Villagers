using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianKingsWater : AbstractShape
    {
        public EgyptianKingsWater(Point Initialpoint)
        {
            Point topPoint = new Point(Initialpoint.X + 75, Initialpoint.Y + 75);
            addShape(new Circle(Initialpoint, topPoint));
        }
    }
}
