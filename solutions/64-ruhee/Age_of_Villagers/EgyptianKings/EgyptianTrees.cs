using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.EgyptianKings
{
    class EgyptianTrees:CShape
    {
        public EgyptianTrees(Point pt)
        {
            Point pt1 = new Point(pt.X + 50, pt.Y + 10);
            Point pt2 = new Point(pt.X - 50, pt.Y + 10);
            Point pt3 = new Point(pt.X + 25, pt.Y +  5);
            Point pt4 = new Point(pt.X - 25, pt.Y +  5);
            Point pt5 = new Point(pt.X + 55, pt.Y + 10);
            Point pt6 = new Point(pt.X + 45, pt.Y + 10);
            Point pt7 = new Point(pt.X - 55, pt.Y + 10);
            Point pt8 = new Point(pt.X - 45, pt.Y + 10);

            AddComponent(new Line(pt, pt1));
            AddComponent(new Line(pt, pt2));
            AddComponent(new Line(pt3, pt5));
            AddComponent(new Line(pt3, pt6));
            AddComponent(new Line(pt4, pt7));
            AddComponent(new Line(pt4, pt8));
        }
    }
}
