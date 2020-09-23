using System.Drawing;

namespace age_of_villagers
{
    class Egypthouse : IComplexShape
    {
        Pen pen = new Pen(Color.Brown);
        public void drawComponent(Graphics g, Point p)
        {
            Point p1 = new Point(p.X + 8, p.Y + 32);
            Point p2 = new Point(p.X - 16, p.Y + 26);
            Point p3 = new Point(p.X + 18, p.Y + 18);

            Triangle triangle = new Triangle(p, p1, p2);
            triangle.draw(g, pen);
            g.DrawLine(pen, p, p3);
            g.DrawLine(pen, p3, p1);

        }
    }


}
