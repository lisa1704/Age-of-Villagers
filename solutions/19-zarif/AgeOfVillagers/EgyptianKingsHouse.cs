using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianKingsHouse : CompositeShape
    {
        public EgyptianKingsHouse(Point point)
        {
            Point _toppoint = point;
            Point _topLeft = new Point(_toppoint.X - 8, _toppoint.Y + 24);
            Point _bottomRight = new Point(_toppoint.X + 8, _toppoint.Y + 16);
            Point _topRight = new Point(_bottomRight.X, _topLeft.Y);


            addShape(new BaseTriangle(_toppoint, _topLeft, _topRight));
          
        }
    }
}
