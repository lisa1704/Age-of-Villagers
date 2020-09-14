using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class Rectangle : CompositeShape
    {
        public Rectangle(Point topLeft, Point bottomRight)
        {
            var topRight = new Point(bottomRight.X, topLeft.Y);
            var bottomLeft = new Point(topLeft.X, bottomRight.Y);

            AddComponent(new Line(topLeft, topRight));
            AddComponent(new Line(topLeft, bottomLeft));
            AddComponent(new Line(bottomLeft, bottomRight));
            AddComponent(new Line(bottomRight, topRight));
        }

    }
}
