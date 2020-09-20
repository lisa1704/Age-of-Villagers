using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ageofvillagers
{
    class Rectangle : IShape
    {
        
        private int X;
        private int Y;
        private Graphics g;
        private Pen p;
        public Rectangle(Graphics g,Pen p,int X,int Y)
        {
            this.g = g;
            this.p = p;
            this.X = X;
            this.Y = Y;
            
          
        }
        public void drawshape()
        {
            g.DrawLine(p, X, Y, X + 100, Y);
            g.DrawLine(p, X, Y, X, Y + 100);
            g.DrawLine(p, X, Y+ 100, X + 100, Y + 100);
            g.DrawLine(p, X + 100, Y + 100, X+ 100, Y);
            Console.WriteLine("Rectangle Drawn Correctly with size"+100);
        }
    }
}
