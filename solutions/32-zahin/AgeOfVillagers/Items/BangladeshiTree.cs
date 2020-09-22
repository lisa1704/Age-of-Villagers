using System.Drawing;
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
            Point rectanglePoint3 = new Point(point.X - 2, point.Y + 24);
            Point rectanglePoint4 = new Point(point.X + 2, point.Y + 24);
            Point center = new Point(point.X + 12, point.Y + 12);
            Circle circle = new Circle(g, pen, center, 24, 24, 0, 360);
            circle.DrawShape();
            Rectangles rectangle = new Rectangles(g, pen, rectanglePoint1, rectanglePoint2, rectanglePoint3, rectanglePoint4);
            rectangle.DrawShape();
        }
    }
}
