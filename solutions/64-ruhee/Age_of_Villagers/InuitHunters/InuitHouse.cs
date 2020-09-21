using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.InuitHunters
{
    class InuitHouse:CShape
    {
        public InuitHouse(Point pt)
        {
            Point x1 = new Point(pt.X - 50, pt.Y + 50);
            Point x2 = new Point(pt.X + 50, pt.Y + 50);


            AddComponent(new Line(x1, x2));
            AddComponent(new Arc(x1.X,x2.Y,80,100,0,-180));
            AddComponent(new Arc(x1.X+20,x2.Y-20,60,80,0,-180));

        }
    }
}
