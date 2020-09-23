using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_of_villagers
{
    class Triangle : IShape
    {
        Point a,b,c;
       
        Pen pen;
        Graphics g;
        public Triangle(Graphics g, Pen pen, Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.g = g;
            this.pen = pen;
            
        }

        public void Draw()
        {
            g.DrawLine(pen, a, b);
            g.DrawLine(pen, a, c);
            g.DrawLine(pen, b, c); 
        }

    }
}
