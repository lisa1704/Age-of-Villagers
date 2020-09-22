using System.Drawing;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class BangladeshiHouse : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point trianglePoint1 = new Point(point.X + 16, point.Y - 16);
            Point trianglePoint2 = new Point(point.X + 24, point.Y);
            Point rectanglePoint1 = new Point(point.X, point.Y + 16);
            Point rectanglePoint2 = new Point(trianglePoint2.X, trianglePoint2.Y + 16);
            Triangle triangle = new Triangle(g, pen, point, trianglePoint1, trianglePoint2);
            triangle.DrawShape();
            Rectangles rectangle = new Rectangles(g, pen, point, trianglePoint2, rectanglePoint1, rectanglePoint2);
            rectangle.DrawShape();
        }
    }
}
