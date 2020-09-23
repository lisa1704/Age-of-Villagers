using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.BangladeshiFarmers
{
    public class BangladeshiWaterS:CShape
    {
        public BangladeshiWaterS(Point pt)
        {
            Point pt1 = new Point(pt.X - 3, pt.Y + 2);
            Point pt2 = new Point(pt.X - 8, pt.Y + 10);
            Point pt3 = new Point(pt.X - 2, pt.Y + 16);
            Point pt4 = new Point(pt.X, pt.Y + 12);
            Point pt5 = new Point(pt.X + 5, pt.Y + 16);
            Point pt6 = new Point(pt.X + 16, pt.Y + 8);
            Point pt7 = new Point(pt.X + 7, pt.Y);
            Point pt8 = new Point(pt.X + 3, pt.Y + 4);

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
