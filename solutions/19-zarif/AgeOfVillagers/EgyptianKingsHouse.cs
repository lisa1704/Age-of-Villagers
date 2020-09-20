using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianKingsHouse : CompositeShape 
    {
        Point _toppoint;
        public EgyptianKingsHouse(Point point)
        {
            _toppoint = point;
            Point _topLeft = new Point(_toppoint.X - 8, _toppoint.Y + 24);
            Point _bottomRight = new Point(_toppoint.X + 8, _toppoint.Y + 16);
            Point _topRight = new Point(_bottomRight.X, _topLeft.Y);
            Point _bottombehind = new Point(_topRight.X+4, _topRight.Y - 16);

            addShape(new BaseTriangle(_toppoint, _topLeft, _topRight));
            addShape(new BaseLine(_toppoint,_bottombehind));
            addShape(new BaseLine(_topRight,_bottombehind));
        }

      
    }
}
