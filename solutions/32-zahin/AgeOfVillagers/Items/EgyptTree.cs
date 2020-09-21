using System.Drawing;

namespace AgeOfVillagers.Items
{
    class EgyptTree : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point p1 = new Point(point.X + 25, point.Y - 25);
            Point p2 = new Point(point.X - 25, point.Y - 25);
            Point p3 = new Point(p1.X + 25, p1.Y - 25);
            Point p4 = new Point(p1.X, p1.Y - 25);
            Point p5 = new Point(p1.X + 25, point.Y - 25);
            Point p6 = new Point(p2.X + 25, p2.Y - 25);
            Point p7 = new Point(p2.X - 5, p2.Y - 25);
            Point p8 = new Point(p2.X - 25, p2.Y - 25);
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
