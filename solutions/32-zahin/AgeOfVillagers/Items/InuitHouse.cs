using System.Drawing;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class InuitHouse : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point p1 = new Point(point.X - 75, point.Y);
            Point p2 = new Point(point.X + 75, point.Y);
            Point p3 = new Point(point.X - 50, point.Y - 50);
            Circle innerCircle = new Circle(g, pen, point, 50, 50, 180, 180);
            innerCircle.DrawShape();
            Circle outerCircle = new Circle(g, pen, p3, 150, 150, 180, 180);
            outerCircle.DrawShape();
            g.DrawLine(pen, p1, p2);
        }
    }
}
