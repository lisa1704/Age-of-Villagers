using System.Drawing;

namespace AgeOfVillagers.Items
{
    class BangladeshiWater : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point p1 = new Point(point.X - 5, point.Y + 16);
            Point p2 = new Point(point.X, point.Y + 16);
            Point p3 = new Point(point.X + 5, point.Y + 16);
            Point p4 = new Point(point.X + 5, point.Y + 16);
            Point p5 = new Point(point.X + 16, point.Y + 5);
            Point p6 = new Point(point.X + 16, point.Y);
            Point p7 = new Point(point.X + 5, point.Y + 5);
            Point p8 = new Point(point.X + 5, point.Y);
            g.DrawLine(pen, point, p1);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p2, p3);
            g.DrawLine(pen, p3, p4);
            g.DrawLine(pen, p4, p5);
            g.DrawLine(pen, p5, p6);
            g.DrawLine(pen, p6, p7);
            g.DrawLine(pen, p7, p8);
            g.DrawLine(pen, p8, point);

        }
    }
}
