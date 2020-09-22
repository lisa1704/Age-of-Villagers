using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Age_of_villagers.Shape
{
    class Arc : IShape
    {
        private readonly Point point;
        private float x, y, w, h, sA, swA;
        public Arc(Point topLeft, Point bottomRight)
        {
            x = topLeft.X;
            y = topLeft.Y;
            w = bottomRight.X - topLeft.X;
            h = bottomRight.Y - topLeft.Y;
            sA = 0;
            swA = 180;
        }
        public void draw(Graphics g, Pen p)
        {
            g.DrawArc(p, x, y, w, h, sA, swA);
        }
    }
}
