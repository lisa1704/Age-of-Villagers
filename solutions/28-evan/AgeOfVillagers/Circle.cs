using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Circle : IShape
    {
        Point x,y;
        int r, h, w;
        Graphics g;
        Pen p;
        public Circle(Graphics g, Pen p, Point x,Point y,int r,int h,int w)
        {
            this.g = g;
            this.p = p;
            this.x = x;
            this.y = y;
            this.r = r;
            this.h = h;
            this.w = w;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void DrawShape(Graphics g, Pen p)
        {
            
        }
    }
}
