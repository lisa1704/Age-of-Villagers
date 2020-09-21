using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class BangladeshiHouse : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point trianglePoint1 = new Point(point.X + 25, point.Y - 25);
            Point trianglePoint2 = new Point(point.X + 50, point.Y);
            Point rectanglePoint1 = new Point(point.X, point.Y + 25);
            Point rectanglePoint2 = new Point(trianglePoint2.X, trianglePoint2.Y + 25);
            Triangle triangle = new Triangle(g, pen, point, trianglePoint1, trianglePoint2);
            triangle.DrawShape();
            Rectangles rectangle = new Rectangles(g, pen, point, trianglePoint2, rectanglePoint1, rectanglePoint2);
            rectangle.DrawShape();
        }
    }
}
