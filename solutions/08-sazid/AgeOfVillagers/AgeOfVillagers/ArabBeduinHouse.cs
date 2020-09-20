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
        public ArabBeduinHouse(Point clickPoint)
        {
            Point p1 = new Point(clickPoint.X - 24, clickPoint.Y + 50);
            Point p2 = new Point(clickPoint.X + 16, clickPoint.Y + 50);
            Point p3 = new Point(clickPoint.X + 25, clickPoint.Y - 30);
            Point p4 = new Point(p2.X + 25, p2.Y - 30);


            addShape(new TriangleShape(p2, p1, clickPoint));
            addShape(new LineShape(p3, clickPoint));
            addShape(new LineShape(p2, p4));
            addShape(new LineShape(p3, p4));
        }
    }
}
