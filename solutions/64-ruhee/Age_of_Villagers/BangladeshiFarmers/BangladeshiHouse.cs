using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.BangladeshiFarmers
{
    public class BangladeshiHouse:CShape
    {
        public BangladeshiHouse(Point pt)
        {
            Point Top = new Point(pt.X, pt.Y);
            Point TopLeft = new Point(pt.X - 50, pt.Y + 30);
            Point BottomRight = new Point(pt.X + 50, pt.Y + 80);
            Point TopRight = new Point(BottomRight.X, TopLeft.Y);

            AddComponent(new Age_of_Villagers.Rectangle(TopLeft, BottomRight));
            AddComponent(new Triangle(Top, TopLeft, TopRight));
        }
    }
}
