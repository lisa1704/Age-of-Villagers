using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace empty_project
{
    class Triangle : IShapeElement
    {
        Point first_point, second_point, third_point;
        public Triangle(Point first_point, Point second_point, Point third_point)
        {
            this.first_point = first_point;
            this.second_point = second_point;
            this.third_point = third_point;
        }
        public void Draw(Graphics graphics)
        {
            var pen = new Pen(Color.Black, 1);
            graphics.DrawLine(pen, first_point, second_point);
            graphics.DrawLine(pen, second_point, third_point);
            graphics.DrawLine(pen, first_point, third_point);
        }

    }
}
