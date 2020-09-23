using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianKingsTree : CompositeShape 
    {
        private Point _point;

        public EgyptianKingsTree(Point point)
        {
            _point = point;
            Point _upbranchright = new Point(point.X + 8, point.Y - 12);
            Point _upbranchleft = new Point(point.X - 8, point.Y - 12);
            addShape(new BaseLine(point,_upbranchright));
            addShape(new BaseLine(point, _upbranchleft));
            addShape(new BaseLine(_upbranchright,new Point(_upbranchright.X+8,_upbranchright.Y-8)));
            addShape(new BaseLine(_upbranchright, new Point(_upbranchright.X - 8, _upbranchright.Y - 8)));
            addShape(new BaseLine(_upbranchright, new Point(_upbranchright.X, _upbranchright.Y - 12)));

            addShape(new BaseLine(_upbranchleft, new Point(_upbranchleft.X + 8, _upbranchleft.Y - 8)));
            addShape(new BaseLine(_upbranchleft, new Point(_upbranchleft.X - 8, _upbranchleft.Y - 8)));
            addShape(new BaseLine(_upbranchleft, new Point(_upbranchleft.X, _upbranchleft.Y - 12)));



        }

       
    }
}
