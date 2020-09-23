using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Shapes
{
    class Rectangle : ComposeShape
    {
        private Point p1, p2;
        public Rectangle(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            AddShape(new Line(p1, new Point(p2.X, p1.Y)));
            AddShape(new Line(p1, new Point(p1.X, p2.Y)));
            AddShape(new Line(new Point(p2.X, p1.Y), p2));
            AddShape(new Line(new Point(p1.X, p2.Y), p2));

        }

    }
}
