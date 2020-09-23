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
        Point point1, point2, point3, point 4;
        Pen pen = new Pen(Color.Black);

        public Rectangle(Graphics g, Point p1, Point p2, Point p3, Point p4)
        {
            graphics = g;
            point = p;

        }

        public void Draw()
        {
          /*  graphics.DrawLine(pen, point, otherPoint1); //a //b
            graphics.DrawLine(pen, otherPoint2, otherPoint3); //c //d
            graphics.DrawLine(pen,point,otherPoint2); //a //c
            graphics.DrawLine(pen,otherPoint1,otherPoint3); //b //d
          */
        }
    }
}
