using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianKingsTree : CompositeShape
    {
        public EgyptianKingsTree(Point point)
        {
            Point _upbranchright = new Point(point.X + 16, point.Y - 18);
            Point _upbranchleft = new Point(point.X - 16, point.Y - 18);
            addShape(new BaseLine(point,_upbranchright));
            addShape(new BaseLine(point, _upbranchleft));
            addShape(new BaseLine(_upbranchright,new Point(_upbranchright.X+12,_upbranchright.Y-8)));
            addShape(new BaseLine(_upbranchright, new Point(_upbranchright.X - 12, _upbranchright.Y - 8)));
            addShape(new BaseLine(_upbranchright, new Point(_upbranchright.X, _upbranchright.Y - 12)));

            addShape(new BaseLine(_upbranchleft, new Point(_upbranchleft.X + 12, _upbranchleft.Y - 8)));
            addShape(new BaseLine(_upbranchleft, new Point(_upbranchleft.X - 12, _upbranchleft.Y - 8)));
            addShape(new BaseLine(_upbranchleft, new Point(_upbranchleft.X, _upbranchleft.Y - 12)));



        }
    }
}
