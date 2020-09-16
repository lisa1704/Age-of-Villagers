using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace empty_project
{
    public class Line : IShapeElement
    {
        Point first_point;
        Point second_point;
        public Line(Point first_point,Point second_point)
        {
            this.first_point = first_point;
            this.second_point = second_point;
        }
        public void Draw(Graphics graphics)
        {
            var pen = new Pen(Color.Black, 1);
            graphics.DrawLine(pen, first_point, second_point);
        }
    }
}
