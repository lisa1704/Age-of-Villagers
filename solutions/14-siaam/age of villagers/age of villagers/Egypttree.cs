using System.Drawing;

namespace age_of_villagers
{
    class Egypttree : IComplexShape
    {
        Pen pen = new Pen(Color.Brown);
        public void drawComponent(Graphics g, Point p)
        {
            Point p1 = new Point(p.X, p.Y + 24);
            Point p2 = new Point(p.X - 6, p.Y);
            Point p3 = new Point(p.X + 6, p.Y);
            Point p4 = new Point(p2.X - 9, p.Y + 5);
            Point p5 = new Point(p3.X + 9, p.Y + 5);
            Point p6 = new Point(p5.X + 9, p.Y + 10);
            Point p7 = new Point(p4.X - 9, p.Y + 10);
            Point p8 = new Point(p1.X - 15, p1.Y - 30);
            Point p9 = new Point(p1.X + 15, p1.Y - 30);
            g.DrawLine(pen, p8, p1);
            g.DrawLine(pen, p9, p1);
            g.DrawLine(pen, p8, p7);
            g.DrawLine(pen, p8, p4);
            g.DrawLine(pen, p8, p2);
            g.DrawLine(pen, p5, p9);
            g.DrawLine(pen, p3, p9);
            g.DrawLine(pen, p6, p9);
        }
    }


}
