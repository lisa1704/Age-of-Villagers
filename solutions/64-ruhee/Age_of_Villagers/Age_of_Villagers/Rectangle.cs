using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Age_of_Villagers
{
    class Rectangle: CShape
    {
        public Rectangle(Point pt1, Point pt2, Point pt3,Point pt4)
        {
            AddComponent(new Line(pt1, pt2));
            AddComponent(new Line(pt2, pt3));
            AddComponent(new Line(pt3, pt4));
            AddComponent(new Line(pt4, pt1));
        }
    }
}
