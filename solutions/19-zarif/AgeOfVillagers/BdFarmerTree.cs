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


            addShape(new BaseCircle(_toppoint,12,24));

            addShape(new BaseRectangle(_toppoint,);


            /*circleShape = new arc(point, radius, 0, 360);
            circleShape.draw(g, pen);*/
        }
    }
}
