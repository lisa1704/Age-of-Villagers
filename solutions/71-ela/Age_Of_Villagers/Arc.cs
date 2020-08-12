using System;
using System.Drawing;

namespace Age_Of_Villagers
{
    class Arc : IShapes1
    {

     
     

      

        public void Draw(Graphics g, int x, int y, int height, int width, int rotate)
        {
            Pen p = new Pen(Color.Black);

            g.DrawArc(p, new RectangleF(new PointF(x,y),new SizeF(new PointF(width,height))),0,rotate);
        }

        public Rectangle shape()
        {
            throw new NotImplementedException();
        }
    }
}
