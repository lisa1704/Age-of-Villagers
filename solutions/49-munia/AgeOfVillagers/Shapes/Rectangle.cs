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
        Point point, otherPoint1, otherPoint2, otherPoint3;
        Pen pen = new Pen(Color.Black);

        public Rectangle(Graphics g, Point p)
        {
            graphics = g;
            point = p;

            otherPoint1.X = point.X + 30;
            otherPoint1.Y = point.Y ;

            otherPoint2.X = point.X;
            otherPoint2.Y = point.Y-20;

            otherPoint3.X = point.X + 30;
            otherPoint3.Y = point.Y - 20;

        }

        public void Draw()
        {
            graphics.DrawLine(pen, point, otherPoint1); //a //b
            graphics.DrawLine(pen, otherPoint2, otherPoint3); //c //d
            graphics.DrawLine(pen,point,otherPoint2); //a //c
            graphics.DrawLine(pen,otherPoint1,otherPoint3); //b //d

        }
    }
}
