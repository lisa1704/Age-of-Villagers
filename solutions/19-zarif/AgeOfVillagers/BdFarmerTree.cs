using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BdFarmerTree : CompositeShape
    {
        public BdFarmerTree(Point point)
        {

            Point _toppoint = point;
            Point _topRight = new Point(_toppoint.X + 16, _toppoint.Y);
            Point _bottomLeft = new Point(_toppoint.X, _toppoint.Y + 8);
            Point _bottomRight = new Point(_toppoint.X + 16, _toppoint.Y + 8);
            
            addShape(new BaseCircle(_toppoint,12,12));

            addShape(new BaseRectangle(_toppoint,_bottomLeft,_bottomRight,_topRight));


            /*circleShape = new arc(point, radius, 0, 360);
            circleShape.draw(g, pen);*/
        }
    }
}
