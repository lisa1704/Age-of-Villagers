using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class ArabBeduinHouse : AdvancedShape
    {
        public ArabBeduinHouse(Point mainPoint)
        {
            Point topPoint1 = new Point(mainPoint.X - 24, mainPoint.Y + 50);
            Point topPoint2 = new Point(mainPoint.X + 16, mainPoint.Y + 50);
            Point topPoint3 = new Point(mainPoint.X + 25, mainPoint.Y - 30);
            Point topPoint4 = new Point(topPoint2.X + 25, topPoint2.Y - 30);


            addShape(new TriangleShape(topPoint2, topPoint1, mainPoint));
            addShape(new LineShape(topPoint3, mainPoint));
            addShape(new LineShape(topPoint2, topPoint4));
            addShape(new LineShape(topPoint3, topPoint4));
        }
    }
}
