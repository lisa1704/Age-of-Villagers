using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianKingsHouse :AbstractShape
    {
        public EgyptianKingsHouse(Point InitialPoint)
        {
            Point topPoint1 = new Point(InitialPoint.X - 24, InitialPoint.Y + 50);
            Point topPoint2 = new Point(InitialPoint.X + 16, InitialPoint.Y + 50);
            Point topPoint3 = new Point(InitialPoint.X + 35, InitialPoint.Y + 40);


            addShape(new Triangle(topPoint2, topPoint1, InitialPoint));
            addShape(new Triangle(topPoint3, topPoint2, InitialPoint));

        }
    }
}
