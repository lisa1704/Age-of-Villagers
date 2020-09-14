using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Shape
{
    public class Line : IShape
    {
        private readonly Point _point1;
        private readonly Point _point2;

        public Line(Point point1, Point point2)
        {
            _point1 = point1;
            _point2 = point2;
        }

        public void Paint(Graphics graphics)
        {
            var pen = new Pen(Color.Red, 2);
            graphics.DrawLine(pen, _point1, _point2);
        }

        // GetBoundingBox()
        // {

        // }

    }
}
