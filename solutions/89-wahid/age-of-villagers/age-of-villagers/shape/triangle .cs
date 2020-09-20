using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers.shape
{
    class triangle : Ishape
    {
        private readonly Point top;
        private readonly Point bottomLeft;
        private readonly Point bottomRight;

        public triangle(Point top, Point bottomLeft, Point bottomRight)
        {
            this.top = top;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
        }
        public void draw(Graphics g, Pen p)
        {
            throw new NotImplementedException();
        }
    }
}
