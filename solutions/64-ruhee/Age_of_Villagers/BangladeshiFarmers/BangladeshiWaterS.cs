using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.BangladeshiFarmers
{
    class BangladeshiWaterS:CShape
    {
        public BangladeshiWaterS(Point pt)
        {
            Point pt1 = new Point(pt.X - 30, pt.Y + 55);
            Point pt2 = new Point(pt.X, pt.Y + 80);
            Point pt3 = new Point(pt.X + 30, pt.Y + 55);
            Point pt4 = new Point(pt.X + 55, pt.Y + 80);
            Point pt5 = new Point(pt.X + 80, pt.Y + 30);
            Point pt6 = new Point(pt.X + 55, pt.Y);
            Point pt7 = new Point(pt.X + 30, pt.Y + 30);
            Point pt8 = new Point(pt.X + 30, pt.Y);

            AddComponent(new Line(pt, pt1));
            AddComponent(new Line(pt1, pt2));
            AddComponent(new Line(pt2, pt3));
            AddComponent(new Line(pt3, pt4));
            AddComponent(new Line(pt4, pt5));
            AddComponent(new Line(pt5, pt6));
            AddComponent(new Line(pt6, pt7));
            AddComponent(new Line(pt7, pt8));
            AddComponent(new Line(pt8, pt));
        }
    }
}
