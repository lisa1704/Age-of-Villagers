using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
namespace AgeOfVillagers
{
    public class BdFarmerHouse : CompositeShape
    {

        public BdFarmerHouse(Point p)
        {
            Point _toppoint = p;
            Point _topLeft = new Point(_toppoint.X - 8, _toppoint.Y + 8);
            Point _bottomRight = new Point(_toppoint.X + 8, _toppoint.Y + 16);
            Point _topRight = new Point(_bottomRight.X, _topLeft.Y);


            addShape(new BaseTriangle(_toppoint, _topLeft,_topRight ));
            addShape(new BaseRectangle(_topLeft,new Point(_topLeft.X,_bottomRight.Y), _bottomRight,_topRight));

            /*AddComponent(new VShape(baseTopLeft, top, new Point(baseBottomRight.X, baseTopLeft.Y)));
            AddComponent(new Rectangle(baseTopLeft, baseBottomRight));*/
        }

       
       
    }
}
