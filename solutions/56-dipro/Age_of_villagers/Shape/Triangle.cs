using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_of_villagers.Shape
{
    class Triangle : IShape
    {
        private readonly Point t;
        private readonly Point bL;
        private readonly Point bR;

        public Triangle(Point t, Point bL, Point bR)
        {
            this.t = t;
            this.bL = bL;
            this.bR = bR;
        }
        public void draw(Graphics g, Pen p)
        {
            new Line(t, bL).draw(g, p);
            new Line(t, bR).draw(g, p);
            new Line(bL, bR).draw(g, p);
        }
    }
}
