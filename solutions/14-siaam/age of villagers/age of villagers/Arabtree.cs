using System.Drawing;

namespace age_of_villagers
{
    class Arabtree : IComplexShape
    {
        Pen pen = new Pen(Color.Red);
        public void drawComponent(Graphics g, Point p)
        {
            Point rectanglp1 = new Point(p.X - 2, p.Y);
            Point rectanglep2 = new Point(p.X + 2, p.Y);
            Point rectanglep3 = new Point(p.X + 2, p.Y + 18);
            Point rectanglep4 = new Point(p.X - 2, p.Y + 18);

            Rectangle rectangle = new Rectangle(rectanglp1, rectanglep2, rectanglep3, rectanglep4);
            rectangle.draw(g, pen);

            Point p1 = new Point(p.X, p.Y - 30);
            Point p2 = new Point(p.X + 8, p.Y - 25);
            Point p3 = new Point(p.X - 8, p.Y - 25);
            Point p4 = new Point(p.X + 16, p.Y - 20);
            Point p5 = new Point(p.X - 16, p.Y - 20);
            g.DrawLine(pen, p, p1);
            g.DrawLine(pen, p, p2);
            g.DrawLine(pen, p, p3);
            g.DrawLine(pen, p, p4);
            g.DrawLine(pen, p, p5);


        }
    }


}
