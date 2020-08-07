using System;
using System.Drawing;

namespace Age_Of_Villagers
{
    class Triangle : IShapes
    {
        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void Draw(Graphics g, int x, int y, int height, int width)
        {
            Pen p = new Pen(Color.Green);
            g.DrawLine(p, x - (width / 2), y - height, x + (width / 2), y - height);
            g.DrawLine(p, x + (width / 2), y - height, x, y);
           
         
            g.DrawLine(p, x, y, x - (width / 2), y - height);

        }

        public Rectangle shape()
        {
            throw new NotImplementedException();
        }
    }
}
