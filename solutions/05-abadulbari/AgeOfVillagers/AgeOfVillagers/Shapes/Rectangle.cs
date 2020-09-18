using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Shapes
{
    public class Rectangle : IShape
    {
        private readonly Point topLeft;
        private readonly Point topRight;
        private readonly Point bottomLeft;
        private readonly Point bottomRight;

        public Rectangle(Point topLeft, Point topRight, Point bottomLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
        }

        public void draw(Graphics g, Pen p)
        {
            new Line(topLeft,topRight).draw(g, p);
            new Line(topLeft,bottomLeft).draw(g, p);
            new Line(bottomLeft,bottomRight).draw(g, p);
            new Line(bottomRight,topRight).draw(g, p);
        }
    }
}
