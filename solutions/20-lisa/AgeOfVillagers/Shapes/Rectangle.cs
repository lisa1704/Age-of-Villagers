using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Rectangle : IShape
    {
        private Point topLeft;
        private Point bottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
            

        }
        public void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, topLeft.X, topLeft.Y, bottomRight.X, topLeft.Y);
            graphics.DrawLine(pen, topLeft.X, topLeft.Y, topLeft.X, bottomRight.Y);
            graphics.DrawLine(pen, topLeft.X, bottomRight.Y, bottomRight.X, bottomRight.Y);
            graphics.DrawLine(pen, bottomRight.X, topLeft.Y, bottomRight.X, bottomRight.Y);

            
        }
    }
}
