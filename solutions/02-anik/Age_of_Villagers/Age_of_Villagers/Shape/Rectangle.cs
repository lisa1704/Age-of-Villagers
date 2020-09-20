using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Shape
{
    class Rectangle : IShape
    {
        private readonly Point tl;
        private readonly Point tr;
        private readonly Point bl;
        private readonly Point br;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.tl = tl;
            this.tr = new Point(br.X, tl.Y);
            this.bl = new Point(tl.X, br.Y);
            this.br = br;
        }

        public void Draw(Graphics g, Pen p)
        {
            new Line(tl, tr).Draw(g, p);
            new Line(tl, bl).Draw(g, p);
            new Line(bl, br).Draw(g, p);
            new Line(br, tr).Draw(g, p);
        }


    }
}

  
