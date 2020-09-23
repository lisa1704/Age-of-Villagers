using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Age_of_Villagers
{
    class Line : IShape
    {
        private readonly Point pt1;
        private readonly Point pt2;

        public Line(Point pt1, Point pt2)
        {
            this.pt1 = pt1;
            this.pt2 = pt2;
        }

        public void Draw(Graphics g,Pen pen)
        {
            g.DrawLine(pen, pt1,pt2);
        }

    }
}
