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
        Point point1, point2, point3;
        public Triangle(Graphics g, Point p1, Point p2, Point p3)
        {
            graphics = g;
            point1 = p1;
            point2 = p2;
            point3 = p3;
        }

        public void Draw()
        {
            graphics.DrawLine(pen, point1, point2); //a //b
            graphics.DrawLine(pen, point2, point3); //b //c
            graphics.DrawLine(pen, point1, point3); //a //c
        }
    }
}
