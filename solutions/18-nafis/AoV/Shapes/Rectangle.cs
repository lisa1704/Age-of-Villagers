using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Shapes
{
    class Rectangle : IShape
    {
        private Point p1, p2, p3, p4;
        public Rectangle(Point p1, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, p1, p2);
        }
    }
}
