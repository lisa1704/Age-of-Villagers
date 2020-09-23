using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Shapes
{
    class Rectangle
    {
        Graphics graphics;
        Point point1, point2, point3, point4;
        Pen pen = new Pen(Color.Black);

        public Rectangle(Graphics g, Point p1, Point p2, Point p3, Point p4)
        {
            graphics = g;
            point1 = p1;
            point2 = p2;
            point3 = p3;
            point4 = p4;
        }
        public void Draw()
        {
            graphics.DrawLine(pen, point1, point2); //a //b
            graphics.DrawLine(pen, point3, point4); //c //d
            graphics.DrawLine(pen,point1, point3); //a //c
            graphics.DrawLine(pen,point2 ,point4); //b //d

        }
    }
}
