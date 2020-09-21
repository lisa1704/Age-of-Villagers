using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class BangladeshiTree : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point rectanglePoint1 = new Point(point.X - 2, point.Y);
            Point rectanglePoint2 = new Point(point.X + 2, point.Y);
            Point rectanglePoint3 = new Point(point.X - 2, point.Y + 50);
            Point rectanglePoint4 = new Point(point.X + 2, point.Y + 50);
            Circle circle = new Circle(g, pen, point, 50, 50, 0, 360);
            circle.DrawShape();
            Rectangles rectangle = new Rectangles(g, pen, rectanglePoint1, rectanglePoint2, rectanglePoint3, rectanglePoint4);
            rectangle.DrawShape();
        }
    }
}
