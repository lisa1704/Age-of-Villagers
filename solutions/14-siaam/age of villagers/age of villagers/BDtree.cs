using System.Drawing;

namespace age_of_villagers
{
    class BDtree : IComplexShape
    {
        Pen pen = new Pen(Color.Red);
        public void drawComponent(Graphics g, Point p)
        {
            g.DrawArc(pen, p.X, p.Y, 24, 24, 0, 360);
            Point pcenter = new Point(p.X + 12, p.Y + 12);
            Point p1 = new Point(pcenter.X - 4, pcenter.Y);
            Point p2 = new Point(pcenter.X + 4, pcenter.Y);
            Point p3 = new Point(p1.X, p1.Y + 24);
            Point p4 = new Point(p2.X, p3.Y);
            Rectangle rectangle = new Rectangle(p1, p2, p4, p3);
            rectangle.draw(g,pen);
            
        }
    }


}
