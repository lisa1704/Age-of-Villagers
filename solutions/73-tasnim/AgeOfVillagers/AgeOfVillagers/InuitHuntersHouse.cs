using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class InuitHuntersHouse : AbstractShape
    {
        public InuitHuntersHouse(Point mainPoint)
        {
            Point linePoint1 = new Point(mainPoint.X, mainPoint.Y - 100);
            Point linePoint2 = new Point(mainPoint.X + 200, mainPoint.Y - 100);
            Point sidePoint1 = new Point(linePoint1.X - 25, linePoint1.Y + 100);
            Point sidePoint2 = new Point(sidePoint1.X + 150, sidePoint1.Y);

            addShape(new Line(sidePoint1, sidePoint2));
            addShape(new Arc(linePoint1.X, linePoint1.Y, 100F, 200F, 0, sweepAngle: -180.0F));
            addShape(new Arc(linePoint1.X - 25, linePoint1.Y - 50, 150F, 300F, 0, sweepAngle: -180.0F));
        }
    }
}
