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
        public EgyptianHouse(Point clickPoint)
        {
            Point topPoint1 = new Point(clickPoint.X - 24, clickPoint.Y + 50);
            Point topPoint2 = new Point(clickPoint.X + 16, clickPoint.Y + 50);
            Point topPoint3 = new Point(clickPoint.X + 35, clickPoint.Y + 40);


            addShape(new TriangleShape(topPoint2, topPoint1, clickPoint));
            addShape(new TriangleShape(topPoint3, topPoint2, clickPoint));
        }
    }
}
