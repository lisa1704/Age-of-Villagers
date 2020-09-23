using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    public class Circle : IShape
    {
        private readonly float radius;
        private readonly Point point1;
        private readonly IShape mycircle;

        public Circle(Point point1, float radius)
        {
            this.point1 = point1;
            this.radius = radius;
        }
        public void draw(Graphics graphics, Pen pen)
        {
            Arc mycircle = new Arc(point1, radius, radius, 0, 360);
            mycircle.draw(graphics, pen);
        }
    }
}
