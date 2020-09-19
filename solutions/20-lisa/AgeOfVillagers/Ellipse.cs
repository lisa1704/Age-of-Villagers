using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Ellipse : CompositeShape
    {
        private readonly Point topLeft;
        private readonly Point bottomRight;

        public Ellipse(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
            AddComponent(new Arc(topLeft.X, topLeft.Y, bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y, 0, 360));
        }
    }
}
