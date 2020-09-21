using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace AgeOfVillagers
{
    public class ArabBedouinHouse : CompositeShape 
    {
       
        public ArabBedouinHouse(Point point)
        {
            Point _toppoint = point;
            Point _topLeft = new Point(_toppoint.X - 16, _toppoint.Y + 16);
            Point _bottomRight = new Point(_toppoint.X + 16,_topLeft.Y);

            addShape(new BaseTriangle(_toppoint, _topLeft, _bottomRight));

            addShape(new BaseRectangle(_toppoint,_bottomRight,new Point(_bottomRight.X+12,_bottomRight.Y-10), new Point(_toppoint.X+12, _toppoint.Y -10)));

        }

      
    }
}
