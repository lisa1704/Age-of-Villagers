using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers.Age_of_Villagers;

namespace Age_of_Villagers.ArabBedouin
{
    class ArabTrees:CShape
    {
        public ArabTrees(Point pt)
        {
            Point pt1 = new Point(pt.X + 30, pt.Y - 10);
            Point pt2 = new Point(pt.X - 30, pt.Y - 10);
            Point pt3 = new Point(pt.X + 25, pt.Y - 25);
            Point pt4 = new Point(pt.X - 25, pt.Y - 25);
            Point pt5 = new Point(pt.X, pt.Y - 30);
            Point TopLeft = new Point(pt.X - 3, pt.Y);
            Point RightBottom = new Point(pt.X + 3, pt.Y + 50);

            AddComponent(new Age_of_Villagers.Rectangle(TopLeft, RightBottom));
            AddComponent(new Line(pt, pt1));
            AddComponent(new Line(pt, pt2));
            AddComponent(new Line(pt, pt3));
            AddComponent(new Line(pt, pt4));
            AddComponent(new Line(pt, pt5));
        }
    }
}
