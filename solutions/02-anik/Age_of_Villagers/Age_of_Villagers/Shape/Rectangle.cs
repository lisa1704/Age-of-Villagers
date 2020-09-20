using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Shape
{
    class Rectangle : IShape
    {
        private readonly Point topLeft;
        private readonly Point topRight;
        private readonly Point bottomLeft;
        private readonly Point bottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.topRight = new Point(bottomRight.X, topLeft.Y);
            this.bottomLeft = new Point(topLeft.X, bottomRight.Y);
            this.bottomRight = bottomRight;
        }

        public void draw(Graphics g, Pen p)
        {
            new Line(topLeft, topRight).Draw(g, p);
            new Line(topLeft, bottomLeft).Draw(g, p);
            new Line(bottomLeft, bottomRight).Draw(g, p);
            new Line(bottomRight, topRight).Draw(g, p);
        }


    }
}

  
