using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.EgyptianKings
{
    class EgyptianWaterS:CShape
    {
        public EgyptianWaterS(Point pt)
        {
            Point TopPoint = new Point(pt.X + 60, pt.Y + 70);

            AddComponent(new Ellipse(pt, TopPoint));
        }
    }
}
