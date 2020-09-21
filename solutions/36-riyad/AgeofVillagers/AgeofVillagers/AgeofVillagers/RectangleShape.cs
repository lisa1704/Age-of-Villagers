using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class RectangleShape : CompositeShape
    {


        public RectangleShape(Point leftTop, Point RightBottom)
        {
            var topRight = new Point(RightBottom.X, leftTop.Y);
            var bottomLeft = new Point(leftTop.X, RightBottom.Y);


            AddComponents(new LineShape(leftTop, topRight));
            AddComponents(new LineShape(leftTop, bottomLeft));
            AddComponents(new LineShape(bottomLeft, RightBottom));
            AddComponents(new LineShape(RightBottom, topRight));

        }

        public RectangleShape(Point topLeft, Point bottomRight, Point topRight, Point bottomLeft)
        {
            AddComponents(new LineShape(topLeft, topRight));
            AddComponents(new LineShape(topLeft, bottomLeft));
            AddComponents(new LineShape(bottomLeft, bottomRight));
            AddComponents(new LineShape(bottomRight, topRight));
        }


    }
}
