using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_of_Villagers.Shape
{
    public class NewArc : IShape
    {
        private readonly float x;
        private readonly float y;
        private readonly float width;
        private readonly float height;
        private readonly float startAngle;
        private readonly float sweepAngle;

        public NewArc(float x, float y, float width, float height, float startAngle, float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;


           
        }
        public void Paint(Graphics graphics)
        {
            var pen = new Pen(Color.Black, 2);
            graphics.DrawArc(pen, x, y, width, height, startAngle, sweepAngle);
        }

    }
}
