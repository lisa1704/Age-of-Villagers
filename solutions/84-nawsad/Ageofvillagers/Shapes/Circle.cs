using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers
{
    class Circle : IShape
    {
        private Graphics g;
        private Pen p;
        private int X;
        private int Y;
        public Circle(Graphics g, Pen p, int X, int Y)
        {
            this.g = g;
            this.p = p;
            this.X = X;
            this.Y = Y;
            
        }

        public void drawshape()
        {
            g.DrawArc(p, X, Y,100, 100,0,360);
            Console.WriteLine("Circle Drawn Correctly with radias "+100);
        }
    }
}
