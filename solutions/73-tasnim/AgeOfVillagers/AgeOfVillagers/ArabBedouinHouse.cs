using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class ArabBedouinHouse : AbstractShape
    {
        public ArabBedouinHouse(Point initialPoint)
        {
            Point topPoint1 = new Point(initialPoint.X - 24, initialPoint.Y + 50);
            Point topPoint2 = new Point(initialPoint.X + 16, initialPoint.Y + 50);
            Point topPoint3 = new Point(initialPoint.X + 25, initialPoint.Y - 30);
            Point topPoint4 = new Point(topPoint2.X + 25, topPoint2.Y - 30);


            addShape(new Triangle(topPoint2, topPoint1, initialPoint));
            addShape(new Line(topPoint3, initialPoint));
            addShape(new Line(topPoint2, topPoint4));
            addShape(new Line(topPoint3, topPoint4));

        }
    }
}
