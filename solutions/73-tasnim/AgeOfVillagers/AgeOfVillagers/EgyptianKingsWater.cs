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
            Point topPoint = new Point(Initialpoint.X + 48, Initialpoint.Y + 48);
            addShape(new Circle(Initialpoint, topPoint));
        }
    }
}
