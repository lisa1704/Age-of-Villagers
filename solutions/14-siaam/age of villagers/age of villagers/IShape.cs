using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    interface IShape
    {
        void draw(Graphics g, Pen p);
    }

    class Circle : IShape
    {
        
        public void draw(Graphics g, Pen p)
        {
            throw new NotImplementedException();
        }
    }

    class Rectangle : IShape
    {
        
        public void draw(Graphics g, Pen p)
        {
            throw new NotImplementedException();
        }
    }

    class Triangle : IShape
    {
        public void draw(Graphics g, Pen p)
        {
            throw new NotImplementedException();
        }
    }

    class Line : IShape
    {
        Point p1, p2;

        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void draw( Graphics g, Pen p)
        {
           g.DrawLine(p,p1,p2);
        }
    }
}
