using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace Age_of_villagers.Shapes
{
    class Rectangle : IShape
    {
        public void Draw(Graphics g, int x, int y, int height, int width)
        {
            Pen p = new Pen(Color.Red);
            g.DrawLine(p, x, y, x + width, y);
            g.DrawLine(p, x, y, x, y - height);
            g.DrawLine(p, x, y - height, x + width, y - height);
            g.DrawLine(p, x + width, y - height, x + width, y);

        }

        public Rectangle shape()
        {
            throw new NotImplementedException();
        }
    }
}
