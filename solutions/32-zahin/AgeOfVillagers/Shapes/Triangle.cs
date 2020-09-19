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
        public void DrawShape(Graphics g, Point point)
        {
            Point p1 = new Point(point.X - 50, point.Y + 50);
            Point p2 = new Point(point.X + 50, point.Y + 50);
            Pen pen1 = new Pen(Color.Red);
            g.DrawLine(pen1, p1, point);
            g.DrawLine(pen1, p2, point);
            g.DrawLine(pen1, p1, p2);
        }
    }
}
