using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Shape
{
    class Triangle : IShape
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

        public void AddComponent(IShape shape)
        {
            throw new NotImplementedException();
        }

        public void Draw(Graphics g, Pen p)
        {
            new Line(top, bottomLeft).Draw(g, p);
            new Line(top, bottomRight).Draw(g, p);
            new Line(bottomLeft, bottomRight).Draw(g, p);
        }
    }
}