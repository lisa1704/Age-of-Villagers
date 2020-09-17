using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BaseTriangle : CompositeShape
    {
        private readonly Point _p1, _p2, _p3;
       
        public BaseTriangle(Point p1, Point p2, Point p3)
        {
            _p1 = p1;
            _p2 = p2;
            _p3 = p3;

            addShape(new BaseLine(_p1, _p2));
            addShape(new BaseLine(_p2, _p3));
            addShape(new BaseLine(_p3, _p1));

        }


    }
}
