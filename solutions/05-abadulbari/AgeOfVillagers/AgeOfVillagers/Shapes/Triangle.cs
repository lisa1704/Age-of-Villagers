using System;
using System.Drawing;

namespace AgeOfVillagers.Shapes
{
    public class Triangle : IShape
    {
        private readonly Point top;
        private readonly Point bottomLeft;
        private readonly Point bottomRight;

        public Triangle(Point top, Point bottomLeft, Point bottomRight)
        {
            this.top = top;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
        }
        public void draw(Graphics g, Pen p)
        {
            new Line(top, bottomLeft).draw(g, p);
            new Line(top, bottomRight).draw(g, p);
            new Line(bottomLeft, bottomRight).draw(g, p);
        }
    }
}
