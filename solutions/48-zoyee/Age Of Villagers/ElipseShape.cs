using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    class ElipseShape : CompositeShape
    {
        private readonly Point TopLeft;
        private readonly Point BottomRight;
        public ElipseShape(Point TopLeft, Point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.BottomRight = BottomRight;
            AddComponent(new Arc(TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y, 0, 360));
        }
    }
}
