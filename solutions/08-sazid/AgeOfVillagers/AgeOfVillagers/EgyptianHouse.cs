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
            Point p1 = new Point(clickPoint.X - 24, clickPoint.Y + 50);
            Point p2 = new Point(clickPoint.X + 16, clickPoint.Y + 50);
            Point p3 = new Point(clickPoint.X + 35, clickPoint.Y + 40);


            addShape(new TriangleShape(p2, p1, clickPoint));
            addShape(new TriangleShape(p3, p2, clickPoint));
        }
    }
}
