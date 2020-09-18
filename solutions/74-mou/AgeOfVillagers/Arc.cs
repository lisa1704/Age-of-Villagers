using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Arc : IShapes
    {
        private Point p;
        private int height, width, startAngle, sweepAngle;

        public Arc(Point p, int radius, int startAngle, int sweepAngle)
        {
            this.p = p;
            this.height = radius;
            this.width = radius;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        public void draw_shapes(Graphics gr, Pen pen)
        {
            gr.DrawArc(pen, p.X, p.Y, height, width, startAngle, sweepAngle)
        }
    }
}
