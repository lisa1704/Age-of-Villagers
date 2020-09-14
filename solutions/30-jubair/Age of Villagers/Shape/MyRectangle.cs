using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Shape
{
    public class MyRectangle : CompositeShape
    {
       

        public MyRectangle(Point topLeft, Point bottomRight)
        {
            var topRight = new Point(bottomRight.X, topLeft.Y);
            var bottomLeft = new Point(topLeft.X, bottomRight.Y);

            AddComponent(new Line(topLeft, topRight));
            AddComponent(new Line(topRight, bottomRight));
            AddComponent(new Line(bottomRight, bottomLeft));
            AddComponent(new Line(bottomLeft, topLeft));
        }

    }
}
