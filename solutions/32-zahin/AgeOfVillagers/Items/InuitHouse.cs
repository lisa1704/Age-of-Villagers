using System.Drawing;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class InuitHouse : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point p1 = new Point(point.X - 16, point.Y);
            Point p2 = new Point(point.X + 16, point.Y);
            Point p3 = new Point(point.X - 8, point.Y - 16);
            Point center = new Point(point.X - 8, point.Y - 8);
            Circle innerCircle = new Circle(g, pen, center, 8, 8, 180, 180);
            innerCircle.DrawShape();
            Circle outerCircle = new Circle(g, pen, p3, 16, 16, 180, 180);
            outerCircle.DrawShape();
            g.DrawLine(pen, p1, p2);
        }
    }
}
