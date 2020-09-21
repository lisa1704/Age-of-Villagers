using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers.Shapes
{
    class Triangle : IShape
    {
        Point p1;
        Point p2;
        Point p3;
        Pen pen;
        Graphics grap;
        public Triangle(Graphics grap, Pen pen, Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.pen = pen;
            this.g = grap;
        }
        public void CreateShape()
        {
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p1, p3);
            g.DrawLine(pen, p2, p3);
        }
    }
}