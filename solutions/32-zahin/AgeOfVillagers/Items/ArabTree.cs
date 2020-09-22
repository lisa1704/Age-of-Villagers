using System.Drawing;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class ArabTree : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point rectanglpoint1 = new Point(point.X - 1, point.Y);
            Point rectanglepoint2 = new Point(point.X + 1, point.Y);
            Point rectanglepoint3 = new Point(point.X - 1, point.Y + 15);
            Point rectanglepoint4 = new Point(point.X + 1, point.Y + 15);
            Point p1 = new Point(point.X, point.Y - 10);
            Point p2 = new Point(point.X - 5, point.Y - 8);
            Point p3 = new Point(point.X + 5, point.Y - 8);
            Point p4 = new Point(point.X - 12, point.Y - 3);
            Point p5 = new Point(point.X + 12, point.Y - 3);
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
