using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class InuitHuntersHouse : CompositeShape
    {
       

        public InuitHuntersHouse(Point point)
        {
            addShape(new BaseArc(point, 30, 30,0,-180));
            addShape(new BaseArc(new Point(point.X+10, point.Y + 10), 10, 10, 0, -180));
            addShape(new BaseLine(new Point(point.X, point.Y + 15), new Point(point.X + 30, point.Y + 15)));

        }
    }
}
