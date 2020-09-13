using System.Drawing;

namespace AgeOfVillagers
{
    public class MyLine : IShape
    {
        private readonly Point point1;
        private readonly Point point2;

        public MyLine(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, point1, point2);
        }
    }
}
