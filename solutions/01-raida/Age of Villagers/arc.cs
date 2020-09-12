using System.Drawing;

namespace Age_of_Villagers
{
    class arc : IShape
    {
        private readonly Point point;
        private readonly int radius, startAngle, sweepAngle;
        public arc(Point p,int radius, int startAngle,int sweepAngle)
        {
            point = p;
            this.radius = radius;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }
        public void draw(Graphics g, Pen pen)
        {
            g.DrawArc(pen, point.X,point.Y, radius,radius, startAngle, sweepAngle);
        }
    }
}
