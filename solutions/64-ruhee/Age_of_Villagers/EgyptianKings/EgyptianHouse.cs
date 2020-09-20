using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.EgyptianKings
{
    class EgyptianHouse:CShape
    {
        public EgyptianHouse(Point pt)
        {
            Point pt1 = new Point(pt.X - 25, pt.Y + 45);
            Point pt2 = new Point(pt.X + 20, pt.Y + 50);
            Point pt3 = new Point(pt.X + 30, pt.Y + 25);

            AddComponent(new Triangle(pt2, pt1, pt));
            AddComponent(new Triangle(pt3, pt2, pt));
        }
    }
}
