using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace AgeOfVillagers
{
    class Circle : IShape
    {

        private Point point;
        private int h;
        private int w;
        int startAngle = 0;
        int sweepAngle = 360;


        public Circle(Point point, int h, int w)
        {
            this.point = point;
            this.h = h;
            this.w = w;
                        
        }

        public void draw(Pen pen, Graphics graphics)
        {
            Rectangle rectangle = new Rectangle(point.X, point.Y, w, h);
            graphics.DrawEllipse(pen, rectangle);
        }
    }
}
