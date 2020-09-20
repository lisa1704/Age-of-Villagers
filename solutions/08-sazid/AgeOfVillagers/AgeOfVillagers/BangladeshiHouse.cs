using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BangladeshiHouse : AdvancedShape
    {
        public BangladeshiHouse(Point clickPoint, Point p1, Point p3)
        {
            addShape(new RectangleShape(p1, p3));
            addShape(new TriangleShape(clickPoint, p1, new Point(p3.X, p1.Y)));
        }
    }
}
