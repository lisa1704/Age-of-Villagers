using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
   public class BaseRectangle : CompositeShape
    {

        public BaseRectangle(Point p1, Point p2,Point p3,Point p4)
        {


            addShape(new BaseLine(p1, p4));
            addShape(new BaseLine(p1, p2));
            addShape(new BaseLine(p2, p3));
            addShape(new BaseLine(p3, p4));

        }

    }
}
