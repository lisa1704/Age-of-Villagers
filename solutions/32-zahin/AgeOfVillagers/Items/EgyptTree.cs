using System.Drawing;

namespace AgeOfVillagers.Items
{
    class EgyptTree : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point p1 = new Point(point.X + 5, point.Y - 10);
            Point p2 = new Point(point.X - 5, point.Y - 10);
            Point p3 = new Point(p1.X + 5, p1.Y - 20);
            Point p4 = new Point(p1.X + 5, p1.Y - 20);
            Point p5 = new Point(p1.X, point.Y - 15);
            Point p6 = new Point(p2.X + 5, p2.Y - 20);
            Point p7 = new Point(p2.X - 5, p2.Y - 20);
            Point p8 = new Point(p2.X - 10, p2.Y - 20);
            g.DrawLine(pen, point, p1);
            g.DrawLine(pen, point, p2);
            g.DrawLine(pen, p1, p3);
            g.DrawLine(pen, p1, p4);
            g.DrawLine(pen, p1, p5);
            g.DrawLine(pen, p2, p6);
            g.DrawLine(pen, p2, p7);
            g.DrawLine(pen, p2, p8);
        }
    }
}
