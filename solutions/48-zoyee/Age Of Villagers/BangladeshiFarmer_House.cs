using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    class BangladeshiFarmer_House : CompositeShape
    {
        public BangladeshiFarmer_House(Point point)
        {
            Point Top = new Point(point.X, point.Y);
            Point TopLeft = new Point(point.X - 80, point.Y + 40);
            Point BottomRight = new Point(point.X + 80, point.Y + 120);
            Point TopRight = new Point(BottomRight.X, TopLeft.Y);

            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Triangle(Top, TopLeft, TopRight));
        }
    }
}
