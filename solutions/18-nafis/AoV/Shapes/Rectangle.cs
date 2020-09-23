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
        private Point p1, p2;
        public Rectangle(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, p1, new Point(p2.X, p1.Y));
            g.DrawLine(pen, p1, new Point(p1.X, p2.Y));
            g.DrawLine(pen, new Point(p2.X, p1.Y), p2);
            g.DrawLine(pen, new Point(p1.X, p2.Y), p2);
        }
    }
}
