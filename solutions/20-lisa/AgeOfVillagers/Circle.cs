using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Circle : IShape
    {

        private Point point;
        private int radius;
        private IShape circle;

        public Circle(Point point, int radius)
        {
            this.point = point;
            this.radius = radius;

        }

        public void Draw(Graphics graphics, Pen pen)
        {
            circle = new Arc(point, radius, 0, 360);
            circle.Draw(graphics, pen);
            
            
        }
    }
}
