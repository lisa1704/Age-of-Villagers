using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    class EgyptianKings_House : CompositeShape
    {
        public EgyptianKings_House(Point mainPoint)
        {
            Point topPoint1 = new Point(mainPoint.X - 24, mainPoint.Y + 50);
            Point topPoint2 = new Point(mainPoint.X + 16, mainPoint.Y + 50);
            Point topPoint3 = new Point(mainPoint.X + 35, mainPoint.Y + 40);


            AddComponent(new Triangle(topPoint2, topPoint1, mainPoint));
            AddComponent(new Triangle(topPoint3, topPoint2, mainPoint));
        }
    }
}
