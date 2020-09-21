using System.Drawing;

namespace Age_of_villagers.Shapes
{
    class Line : IShape
    {
        private Point point1, point2;
        public Line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
        public void draw(Graphics g, Pen p)
        {
            g.DrawLine(p, point1, point2);
        }
    }
}
