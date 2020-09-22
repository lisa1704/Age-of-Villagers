using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Line : IShape
    {
        Point x, y;
        Pen p;
        Graphics g;

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public Line(Graphics g,Pen p,Point x,Point y)
        {
            this.x = x;
            this.y = y;
            this.g = g;
            this.p = p;
        }

        public void DrawShape(Graphics g, Pen p)
        {
            g.DrawLine(p,x,y);
        }
    }
}
