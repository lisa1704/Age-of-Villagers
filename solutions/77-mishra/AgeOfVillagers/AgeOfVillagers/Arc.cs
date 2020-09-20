using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Arc : IShape
    {
        //private Point point;
        private int x;
        private int y;
        private int h;
        private int w;
        private int startAngle;
        private int sweepAngle;

        public Arc(Point point, int h, int w, int startAngle, int sweepAngle)
        {
            //this.point = point;
            this.h = h;
            this.w = w;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }
        public void draw(Pen pen, Graphics graphics)
        {
            //Rectangle shape = new Rectangle(point.X, point.Y, h, w);
            graphics.DrawArc(pen, x, y, h, w, startAngle, sweepAngle);
        }
    }
}
