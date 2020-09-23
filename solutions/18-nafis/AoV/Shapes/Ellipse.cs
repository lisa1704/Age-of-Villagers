using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Shapes
{
    class Ellipse : ComposeShape
    {
        private Point p1, p2;
        public Ellipse(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            AddShape(new Arc(p1.X, p1.Y, p2.X-p1.X, p2.Y-p1.Y, 0, 360));
        }
       
    }
}
