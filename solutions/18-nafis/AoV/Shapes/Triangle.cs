using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Shapes
{
    class Triangle : ComposeShape
    {
        private Point p1, p2, p3;
        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            AddShape(new Line(p1, p2));
            AddShape(new Line(p2, p3));
            AddShape(new Line(p3, p1));
        }

    }
}
