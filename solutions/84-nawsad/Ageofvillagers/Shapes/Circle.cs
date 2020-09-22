using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
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
        private int arc_angle=360;
        private int Xlength =100;
        private int Ylength = 100;
        public Circle(Graphics g, Pen p, int X, int Y)
        {
            this.g = g;
            this.p = p;
            this.X = X;
            this.Y = Y;
            
        }
        public Circle(Graphics g,Pen p,int X,int Y,int arc_angle)
        {
            this.g = g;
            this.p = p;
            this.X = X;
            this.Y = Y;
            this.arc_angle = arc_angle;
        }
        public Circle(Graphics g, Pen p, int X, int Y,int Xlength,int Ylength,int arc_angle)
        {
            this.g = g;
            this.p = p;
            this.X = X;
            this.Y = Y;
            this.Xlength = Xlength;
            this.Ylength = Ylength;
            this.arc_angle = arc_angle;
        }

        public void drawshape()
        {
            g.DrawArc(p, X, Y,Xlength, Ylength,0,arc_angle);
            Console.WriteLine("Circle Drawn Correctly with radias "+100);
        }
    }
}
