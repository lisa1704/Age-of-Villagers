using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers
{
    class Triangle : IShape
    {
        private int X;
        private int Y;
        private Graphics g;
        private Pen p;
        public Triangle(Graphics g, Pen p, int X, int Y)
        {
            this.g = g;
            this.p = p;
            this.X = X;
            this.Y = Y;
            
        }
        public void drawshape()
        {
            g.DrawLine(p, X, Y, X + 100 ,Y);
            g.DrawLine(p, X, Y,(X+ X + 100) / 2, Y - 87);
            g.DrawLine(p, X + 100, Y, (X + X + 100) / 2, Y - 87);
            Console.WriteLine("Triangle Has been Drawn Properly");
        }
    }
}
