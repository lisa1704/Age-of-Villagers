using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_Of_Villagers
{
    class Rectangle : IShape
    {
        private readonly Point TopLeft;
        private readonly Point BottomRight;
        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
        }
        public void Draw(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, TopLeft.X, TopLeft.Y, BottomRight.X, TopLeft.Y);
            g.DrawLine(pen, TopLeft.X, TopLeft.Y, TopLeft.X, BottomRight.Y);
            g.DrawLine(pen, TopLeft.X, BottomRight.Y, BottomRight.X, BottomRight.Y);
            g.DrawLine(pen, BottomRight.X, TopLeft.Y, BottomRight.X, BottomRight.Y);
        }
    }
}
