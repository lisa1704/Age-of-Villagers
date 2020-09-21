using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class RectangleShape : IShapeItem
    {
        private Point leftTop;
        private Point RightBottom;

        public RectangleShape(Point leftTop, Point RightBottom)
        {
            this.leftTop = leftTop;
            this.RightBottom = RightBottom;
        }

        public void Paint(Graphics g, Pen p)
        {
            var pen = new Pen(Color.Black, 1);


            g.DrawLine(pen, leftTop.X, leftTop.Y, RightBottom.X, leftTop.Y);
            g.DrawLine(pen, leftTop.X, leftTop.Y, leftTop.X, RightBottom.Y);
            g.DrawLine(pen, leftTop.X, RightBottom.Y, RightBottom.X, RightBottom.Y);
            g.DrawLine(pen, RightBottom.X, leftTop.Y, RightBottom.X, RightBottom.Y);
        }
    }
}
