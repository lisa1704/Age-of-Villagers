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

    
    class Rectangle : IShape
    {
        Point p1, p2,p3,p4;

        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        public void draw(Graphics g, Pen p)
        {
            g.DrawLine(p,p1,p2);
            g.DrawLine(p,p2, p3);
            g.DrawLine(p, p3, p4);
            g.DrawLine(p, p4, p1);
        }
    }

    class Triangle : IShape
    {
        Point p1,p2, p3;

        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public void draw(Graphics g, Pen p)
        {
            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p2, p3);
            g.DrawLine(p, p3, p1);
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
