using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace empty_project
{
    class Rectangle : IShapeElement
    {
        Point TopLeft_point;
        Point BottomRight_point;
        public Rectangle(Point TopLeft_pont,Point BottomRight_point)
        {
            this.TopLeft_point =TopLeft_pont ;
            this.BottomRight_point = BottomRight_point;
        }
        public void Draw(Graphics graphics)
        {
            var pen = new Pen(Color.Black, 1);
            graphics.DrawLine(pen, TopLeft_point.X, TopLeft_point.Y, BottomRight_point.X, TopLeft_point.Y);
            graphics.DrawLine(pen, TopLeft_point.X, TopLeft_point.Y, TopLeft_point.X, BottomRight_point.Y);
            graphics.DrawLine(pen, TopLeft_point.X, BottomRight_point.Y, BottomRight_point.X, BottomRight_point.Y);
            graphics.DrawLine(pen, BottomRight_point.X, TopLeft_point.Y, BottomRight_point.X, BottomRight_point.Y);
        }
    }
}
