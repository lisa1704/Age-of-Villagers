using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Circle : AbstractShape
    {
        private Point topleft;
        private Point bottomright;

        public Circle(Point topleft, Point bottomright)
        {
            this.topleft = topleft;
            this.bottomright = bottomright;
            addShape(new Arc(topleft.X, topleft.Y, bottomright.X - topleft.X, bottomright.Y - topleft.Y, 0, 360));
        }
    }
}
