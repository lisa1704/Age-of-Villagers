using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class ArabBedouinTree : CompositeShape
    {
        Point _toppoint;
        public ArabBedouinTree(Point point)
        {
            
            
            _toppoint = point;

            Point _topRight = new Point(_toppoint.X + 3, _toppoint.Y);
            Point _bottomLeft = new Point(_toppoint.X, _toppoint.Y + 12);
            Point _bottomRight = new Point(_toppoint.X + 3, _toppoint.Y + 12);

            int mid_x = (_toppoint.X + _topRight.X) / 2;
            int mid_y = (_toppoint.Y + _topRight.Y) / 2;
            Point mid = new Point(mid_x, mid_y);
            addShape(new BaseRectangle(_toppoint, _bottomLeft, _bottomRight, _topRight));
            addShape(new BaseLine(mid,new Point(mid_x,mid_y-14)));
            addShape(new BaseLine(mid, new Point(mid_x+6,mid_y-14)));
            addShape(new BaseLine(mid, new Point(_topRight.X+12, _topRight.Y - 10)));
            addShape(new BaseLine(mid, new Point(mid_x - 6, mid_y - 12)));
            addShape(new BaseLine(_toppoint, new Point(_toppoint.X - 10, _toppoint.Y - 10)));
           
        }

      
    }
}
