using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Arc : IShape
    {
      
        private Point point;
        private int width;
        private int height;
        private int radius;
        private float angle1;
        private float angle2;

        public Arc(Point point, int radius,float angle1, float angle2)
        {
            this.point = point;
            this.width = radius;
            this.height = radius;
            this.angle1 = angle1;
            this.angle2 = angle2;

        }


        public void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawArc(pen, point.X, point.Y, width, height, angle1, angle2);
        }

    }
}
