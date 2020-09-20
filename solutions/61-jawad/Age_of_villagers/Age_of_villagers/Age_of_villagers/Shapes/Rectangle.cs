﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_villagers.Shapes
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
            new Line(topLeft, topRight).draw(g, p);
            new Line(topLeft, bottomLeft).draw(g, p);
            new Line(bottomLeft, bottomRight).draw(g, p);
            new Line(bottomRight, topRight).draw(g, p);
        }
    }
}
