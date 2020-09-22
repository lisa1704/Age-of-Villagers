using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace AgeOfVillagers
{
    class Circle : IShapes
    {
        private Point p;
        private int radius;
        private IShapes circles;
        public Circle(Point p, int r)
        {
            this.p = p;
            this.radius = r;
        }

        public void DrawShapes(Graphics gr)
        {
            var pen = new Pen(Color.Black, 1);
            circles = new Arc(p, radius, 0, 360);
            circles.DrawShapes(gr);
        }
    }
}

