using System.Drawing;

namespace AgeOfVillagers
{
    public class MyArc : IShape
    {
        private readonly float x;
        private readonly float y;
        private readonly float width;
        private readonly float height;
        private readonly float startAngle;
        private readonly float sweepAngle;

        public MyArc(float x, float y, float width, float height, float startAngle, float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        public void Draw(Graphics g, Pen p)
        {
            g.DrawArc(p, x, y, width, height, startAngle, sweepAngle);
        }
    }

}
