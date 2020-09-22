using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Rectangle : IShape
    {
        Point w, x, y, z;
        Pen p;
        Graphics g;

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public Rectangle(Graphics g, Pen p, Point w, Point x, Point y, Point z)
        {
            this.w = w;
            this.x = x;
            this.y = y;
            this.z = z;
            this.g = g;
            this.p = p;
        }

        public void DrawShape(Graphics g, Pen p)
        {
            g.DrawLine(p, w, x);
            g.DrawLine(p, w, y);
            g.DrawLine(p, y, z);
            g.DrawLine(p, x, y);
        }

        internal void DrawShape()
        {
            throw new NotImplementedException();
        }
    }
}
