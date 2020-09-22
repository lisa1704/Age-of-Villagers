using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Triangle : IShape
    {
        Point x, y, z;
        Pen p;
        Graphics g;

        public void Draw()
        {
            throw new NotImplementedException();
        }
        public Triangle(Graphics g, Pen p, Point x, Point y,Point z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.g = g;
            this.p = p;
        }

        public void DrawShape(Graphics g, Pen p)
        {
            g.DrawLine(p, x, y);
            g.DrawLine(p, x, z);
            g.DrawLine(p, y, y);
        }

        internal void DrawShape()
        {
            throw new NotImplementedException();
        }
    }
}
