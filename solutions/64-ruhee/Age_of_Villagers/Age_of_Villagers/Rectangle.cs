using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Age_of_Villagers
{
    class Rectangle: CShape
    {
        private readonly Point UpperLeft;
        private readonly Point BottomRight;
        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.UpperLeft = topLeft;
            this.BottomRight = bottomRight;
        }
        public void Draw(Graphics g,Pen pen)
        {
            g.DrawLine(pen, UpperLeft.X, UpperLeft.Y, BottomRight.X, UpperLeft.Y);
            g.DrawLine(pen, UpperLeft.X, UpperLeft.Y, UpperLeft.X, BottomRight.Y);
            g.DrawLine(pen, UpperLeft.X, BottomRight.Y, BottomRight.X, BottomRight.Y);
            g.DrawLine(pen, BottomRight.X, UpperLeft.Y, BottomRight.X, BottomRight.Y);
        }
    }
}
