using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Shapes
{
    class Triangle
    {
        Graphics graphics;
        Pen pen = new Pen(Color.Black);
        Point point, otherPoint1, otherPoint2,otherPoint3;
        public Triangle(Graphics g, Point p)
        {
            graphics = g;
            point = p;

            otherPoint1.X = point.X;
            otherPoint1.Y = point.Y - 20;

            otherPoint2.X = point.X - 30;
            otherPoint2.Y = point.Y - 20;

            otherPoint3.X = point.X - 15;
            otherPoint3.Y = point.Y - 35;
        }

        public void Draw()
        {
            graphics.DrawLine(pen, otherPoint1,otherPoint2);
            graphics.DrawLine(pen, otherPoint2, otherPoint3);
            graphics.DrawLine(pen, otherPoint1, otherPoint3);

        }
    }
}
