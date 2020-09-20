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
        private int Xlength=100;
        private int Ylength=100;
        public Rectangle(Graphics g,Pen p,int X,int Y)
        {
            this.g = g;
            this.p = p;
            this.X = X;
            this.Y = Y;
            
          
        }
        public Rectangle(Graphics g, Pen p, int X, int Y,int Xlength,int Ylength)
        {
            this.g = g;
            this.p = p;
            this.X = X;
            this.Y = Y;
            this.Xlength = Xlength;
            this.Ylength = Ylength;
        }
        public void drawshape()
        {
            g.DrawLine(p, X, Y, X + Xlength, Y);
            g.DrawLine(p, X, Y, X, Y + Ylength);
            g.DrawLine(p, X, Y+ Ylength, X + Xlength, Y + Ylength);
            g.DrawLine(p, X + Xlength, Y + Ylength, X+ Xlength, Y);
            Console.WriteLine("Rectangle Drawn Correctly with size"+100);
        }
    }
}
