using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.BangladeshiFarmers
{
    public class BangladeshiTrees:CShape
    {
        public BangladeshiTrees(Point pt)
        {
            Point Top = new Point(pt.X, pt.Y);
            Point TopRight = new Point(pt.X + 60, pt.Y + 70);
            Point BottomRight = new Point(pt.X + 28, pt.Y + 100);
            Point TopLeft = new Point(pt.X + 33, pt.Y + 45);

            AddComponent(new Age_of_Villagers.Rectangle(TopLeft, BottomRight));
            AddComponent(new Arc(Top.X, TopRight.Y, 100, 100, 0, -360));
        }
    }
}
