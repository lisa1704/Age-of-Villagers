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
        private readonly Point top,bottom_left,bottom_right;
  
        public Triangle(Point top, Point bottom_left, Point bottom_right)
        {
            this.top = top;
            this.bottom_left = bottom_left;
            this.bottom_right = bottom_right;
        }
        public void draw(Graphics g, Pen p)
        {
            new Line(top, bottom_left).draw(g, p);
            new Line(top, bottom_right).draw(g, p);
            new Line(bottom_left, bottom_right).draw(g, p);
        }
    }
}
