using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Triangle : CompositeShape
    {
        public Triangle(Point p1,Point p2, Point p3)
        {
            AddComponent(new Line(p1, p2));
            AddComponent(new Line(p2, p3));
            AddComponent(new Line(p3, p1));

        }
    }
}
