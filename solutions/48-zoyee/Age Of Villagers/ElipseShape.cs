using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    class ElipseShape : CompositeShape
    {
        private readonly Point topleft;
        private readonly Point bottomright;

        public ElipseShape(Point topleft, Point bottomright)
        {
            this.topleft = topleft;
            this.bottomright = bottomright;
            AddComponent(new Arc(topleft.X, topleft.Y, bottomright.X - topleft.X, bottomright.Y - topleft.Y, 0, 360));
        }
    }
}
