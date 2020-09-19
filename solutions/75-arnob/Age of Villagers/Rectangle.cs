using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Rectangle : CompositeShaping
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
