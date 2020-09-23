using System.Drawing;

namespace age_of_villagers
{
    class Line : IShape
    {
        Point p1, p2;

        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void draw( Graphics g, Pen p)
        {
           g.DrawLine(p,p1,p2);
        }
    }
}
