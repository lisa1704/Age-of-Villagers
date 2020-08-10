﻿using System;
using System.Drawing;

namespace Age_Of_Villagers
{
    class Arc : IShapes
    {

        Pen p;
    
        public Arc()
        {
            p = new Pen(Color.Black);
        }
     

      

        public void Draw(Graphics g, int x, int y, int height, int width, int rotate)
        {
            
            g.DrawArc(p, new RectangleF(new PointF(x,y),new SizeF(new PointF(width,height))),0,360);
        }

        public Rectangle shape()
        {
            throw new NotImplementedException();
        }
    }
}
