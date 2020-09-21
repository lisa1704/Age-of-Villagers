using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeOfVillagers.Items;
using AgeOfVillagers.Shapes;
using System.Drawing;

namespace AgeOfVillagers.Items
{
    class ArabTree : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point rectanglpoint1 = new Point(point.X - 2, point.Y);
            Point rectanglepoint2 = new Point(point.X + 2, point.Y);
            Point rectanglepoint3 = new Point(point.X - 2, point.Y + 50);
            Point rectanglepoint4 = new Point(point.X + 2, point.Y + 50);
            Point p1 = new Point(point.X, point.Y - 35);
            Point p2 = new Point(point.X - 25, point.Y - 25);
            Point p3 = new Point(point.X + 25, point.Y - 25);
            Point p4 = new Point(point.X - 35, point.Y - 10);
            Point p5 = new Point(point.X + 35, point.Y - 10);
            Rectangles rectangle = new Rectangles(g, pen, rectanglpoint1, rectanglepoint2, rectanglepoint3, rectanglepoint4);
            rectangle.DrawShape();
            g.DrawLine(pen, point, p1);
            g.DrawLine(pen, point, p2);
            g.DrawLine(pen, point, p3);
            g.DrawLine(pen, point, p4);
            g.DrawLine(pen, point, p5);
        }
    }
}
