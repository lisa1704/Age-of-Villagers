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
            Point Point1 = new Point(initialPoint.X - 45, initialPoint.Y + 60);
            Point Point2 = new Point(initialPoint.X + 45, initialPoint.Y + 60);
            Point Point3 = new Point(initialPoint.X + 30, initialPoint.Y - 20);
            Point Point4 = new Point(Point2.X + 30, Point2.Y - 20);


            addShape(new Triangle(Point2, Point1, initialPoint));
            addShape(new Line(Point3, initialPoint));
            addShape(new Line(Point2, Point4));
            addShape(new Line(Point3, Point4));

        }
    }
}
