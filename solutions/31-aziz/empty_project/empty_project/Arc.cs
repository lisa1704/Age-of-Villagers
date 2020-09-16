using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace empty_project
{
    class Arc : IShapeElement
    {
        int x_coordinate, y_coordinate, width, height, startAngle, arcAngle;
        public Arc(int x_coordinate, int y_coordinate, int width, int height, int startAngle, int arcAngle)
        {
            this.x_coordinate = x_coordinate;
            this.y_coordinate = y_coordinate;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.arcAngle = arcAngle;
        }
        public void Draw(Graphics graphics)
        {
            var pen = new Pen(Color.Black, 1);
            graphics.DrawArc(pen, x_coordinate, y_coordinate, width, height, startAngle, arcAngle);
        }
    }
}
