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
        public void Draw(Graphics graphics)
        {
            var p = new Pen(Color.Black,1);
            graphics.DrawLine(p, topLeft.X, topLeft.Y, bottomRight.X, topLeft.Y);
            graphics.DrawLine(p, topLeft.X, topLeft.Y, topLeft.X, bottomRight.Y);
            graphics.DrawLine(p, topLeft.X, bottomRight.Y, bottomRight.X, bottomRight.Y);
            graphics.DrawLine(p, bottomRight.X, topLeft.Y, bottomRight.X, bottomRight.Y);

            
        }
    }
}
