using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Age_of_Villagers
{
    class Rectangle: CShape
    {
        private readonly Point pt1;
        private readonly Point pt2;
        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.pt1 = topLeft;
            this.pt2 = bottomRight;
        }
        public void Draw(Graphics g,Pen pen)
        {
            g.DrawLine(pen, pt1.X, pt1.Y, pt2.X, pt1.Y);
            g.DrawLine(pen, pt1.X, pt1.Y, pt1.X, pt2.Y);
            g.DrawLine(pen, pt1.X, pt2.Y, pt2.X, pt2.Y);
            g.DrawLine(pen, pt2.X, pt1.Y, pt2.X, pt2.Y);
        }
    }
}
