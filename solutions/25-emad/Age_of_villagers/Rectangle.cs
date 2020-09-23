using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_of_villagers
{
    class Rectangle : IShape
    {

        Point a,b,c,d;
        Pen pen;
        Graphics g;
        public Rectangle(Graphics g, Pen pen, Point a, Point b, Point c, Point d)
        {

            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.g = g;
            this.pen = pen;

        }

        public void Draw()
        {
            g.DrawLine(pen, a, b);
            g.DrawLine(pen, a, c);
            g.DrawLine(pen, c, d);
            g.DrawLine(pen, b, d); 
        }

       
    }
}
