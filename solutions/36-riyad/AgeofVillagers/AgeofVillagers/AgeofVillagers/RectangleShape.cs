using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class RectangleShape : IShape
    {
        private Point leftTop;
        private Point RightBottom;

        public RectangleShape(Point leftTop, Point RightBottom)
        {
            this.leftTop = leftTop;
            this.RightBottom = RightBottom;
        }

        public void Paint(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, leftTop, RightBottom);
        }
    }
}
