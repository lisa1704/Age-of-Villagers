using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BdFarmerTree : CompositeShape
    {
        Point exlocation;
        public BdFarmerTree(Point point)
        {
            exlocation = point;
            Point _toppoint = new Point(exlocation.X + 6, exlocation.Y+10);

            Point _topRight = new Point(_toppoint.X + 3, _toppoint.Y);
            Point _bottomLeft = new Point(_toppoint.X, _toppoint.Y + 12);
            Point _bottomRight = new Point(_toppoint.X + 3, _toppoint.Y + 12);
            
            addShape(new BaseCircle(exlocation,16,16));

            addShape(new BaseRectangle(_toppoint,_bottomLeft,_bottomRight,_topRight));


        }

        
    }
}
