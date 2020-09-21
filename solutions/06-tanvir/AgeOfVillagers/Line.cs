using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Shapes
{
    class Line : IShape
    {
        Point p1;
        Point p2;
        Pen pen;
        Graphics grap;
        public Line(Graphics grap, Pen pen, Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.pen = pen;
            this.g = grap;
        }
        public void CreateShape()
        {
            g.DrawLine(pen, p1, p2);
        }
    }
}