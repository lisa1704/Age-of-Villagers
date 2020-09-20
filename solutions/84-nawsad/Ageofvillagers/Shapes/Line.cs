using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ageofvillagers
{
     class Line : IShape
     {
        private Graphics g;
        private Pen p;
        private int X;
        private int Y;
        private int Xlength =100;
        private int Ylength = 0;
        public Line(Graphics g, Pen p, int X, int Y)
        {
            this.g = g;
            this.p = p;
            this.X = X;
            this.Y = Y;
            
        }
        public Line(Graphics g, Pen p, int X, int Y,int Xlength)
        {
            this.g = g;
            this.p = p;
            this.X = X;
            this.Y = Y;
            this.Xlength = Xlength;

        }
        public void drawshape()
        {
            g.DrawLine(p, X, Y, X + Xlength, Y+Ylength);
            Console.WriteLine("Line Drawn Correctly with length "+Xlength);
        }

       
    }
}
