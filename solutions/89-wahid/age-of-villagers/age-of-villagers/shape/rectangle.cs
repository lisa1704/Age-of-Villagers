using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers.shape
{
    class rectangle : Ishape
    {
        private readonly Point topLeft;
        private readonly Point topRight;
        private readonly Point bottomLeft;
        private readonly Point bottomRight;

        public rectangle(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.topRight = new Point(bottomRight.X, topLeft.Y);
            this.bottomLeft = new Point(topLeft.X, bottomRight.Y);
            this.bottomRight = bottomRight;
        }
        public void draw(Graphics g, Pen p)
        {
            new line(topLeft, topRight).draw(g, p);
            new line(topLeft, bottomLeft).draw(g, p);
            new line(bottomLeft, bottomRight).draw(g, p);
            new line(bottomRight, topRight).draw(g, p);
        }

    }
}
