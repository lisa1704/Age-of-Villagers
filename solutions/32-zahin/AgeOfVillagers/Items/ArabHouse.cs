using System.Drawing;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class ArabHouse : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point trianglePoint1 = new Point(point.X + 16, point.Y + 20);
            Point trianglePoint2 = new Point(point.X - 16, point.Y + 20);
            Point rectanglePoint1 = new Point(point.X + 13, point.Y - 10);
            Point rectanglePoint2 = new Point(point.X + 24, point.Y + 10);
            Triangle triangle = new Triangle(g, pen, trianglePoint2, trianglePoint1, point);
            triangle.DrawShape();
            Rectangles rectangle = new Rectangles(g, pen, point, rectanglePoint1, trianglePoint1, rectanglePoint2);
            rectangle.DrawShape();
        }
    }
}
