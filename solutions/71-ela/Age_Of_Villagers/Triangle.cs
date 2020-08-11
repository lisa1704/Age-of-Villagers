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

        public void Draw(Graphics g,int x, int y,int height,int width, int rotate)


        {

            Pen p = new Pen(Color.Black);
            g.DrawLine(p, x , y ,x+width, y-rotate);
            g.DrawLine(p, x , y, x + (width / 2)-rotate, y - height-rotate);
            g.DrawLine(p, x + (width / 2) - rotate, y - height - rotate, x + width, y-rotate);



          


        }

        public Rectangle shape()
        {
            throw new NotImplementedException();
        }
    }
}
