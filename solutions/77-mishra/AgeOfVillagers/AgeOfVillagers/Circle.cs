using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace AgeOfVillagers
{
    class Circle : IShape
    {
        //private Point point;
        private int x;
        private int y;
        private int h;
        private int w;

        public Circle(int x, int y, int h, int w)
        {
            //this.point = point;
            this.h = h;
            this.x = x;
            this.y = y;
            this.w = w;
        }
        public void draw(Pen pen, Graphics graphics)
        {
            graphics.DrawEllipse(pen, x, y, h, w);
            
        }
    }
}
