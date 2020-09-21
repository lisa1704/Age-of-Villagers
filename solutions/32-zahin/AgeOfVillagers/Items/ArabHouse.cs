using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class ArabHouse : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point trianglePoint1 = new Point(point.X + 25, point.Y + 50);
            Point trianglePoint2 = new Point(point.X - 25, point.Y + 50);
            Point rectanglePoint1 = new Point(point.X + 50, point.Y - 25);
            Point rectanglePoint2 = new Point(point.X + 50, point.Y + 25);
            Triangle triangle = new Triangle(g, pen, trianglePoint2, trianglePoint1, point);
            triangle.DrawShape();
            Rectangles rectangle = new Rectangles(g, pen, point, rectanglePoint1, trianglePoint1, rectanglePoint2);
            rectangle.DrawShape();
        }
    }
}
