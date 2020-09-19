using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianHouse : AdvancedShape
    {
        public EgyptianHouse(Point mainPoint)
        {
            Point topPoint1 = new Point(mainPoint.X - 24, mainPoint.Y + 50);
            Point topPoint2 = new Point(mainPoint.X + 16, mainPoint.Y + 50);
            Point topPoint3 = new Point(mainPoint.X + 35, mainPoint.Y + 40);


            addShape(new TriangleShape(topPoint2, topPoint1, mainPoint));
            addShape(new TriangleShape(topPoint3, topPoint2, mainPoint));
        }
    }
}
