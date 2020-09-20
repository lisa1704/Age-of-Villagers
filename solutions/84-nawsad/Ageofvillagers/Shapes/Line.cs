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
        public Line(Graphics g, Pen p, int X, int Y)
        {
            this.g = g;
            this.p = p;
            this.X = X;
            this.Y = Y;
            drawshape();
        }
        void drawshape()
        {
            g.DrawLine(p, X, Y, X + 100, Y);
            Console.WriteLine("You are in line");
        }

        void IShape.drawshape()
        {
            throw new NotImplementedException();
        }
    }
}
