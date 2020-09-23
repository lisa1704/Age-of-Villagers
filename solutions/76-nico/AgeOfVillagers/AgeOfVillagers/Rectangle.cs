﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class Rectangle : CompositeShape
    {
        private readonly Point TopLeft;
        private readonly Point BottomRight;
        public Rectangle(Point topLeft, Point BottomRight)
        {
            var TopRight = new Point(BottomRight.X, topLeft.Y);
            var BottomLeft = new Point(topLeft.X, BottomRight.Y);

            AddComponent(new Line(topLeft, BottomLeft));
            AddComponent(new Line(topLeft, TopRight));
            AddComponent(new Line(BottomLeft, BottomRight));
            AddComponent(new Line(BottomRight, TopRight));
        }
        public void Draw(Graphics g)
        {
          throw new NotImplementedException();
        }
    }
}
