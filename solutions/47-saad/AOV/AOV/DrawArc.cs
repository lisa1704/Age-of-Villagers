using System.Drawing;

namespace AOV
{
    class DrawArc : IDraw
    {
        private readonly float x;
        private readonly float y;
        private readonly float height;
        private readonly float width;
        private readonly float startAngle;
        private readonly float sweepAngle;

        public DrawArc(float x, float y, float height, float width, float startAngle, float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }
        public void Draw(Graphics g)
        {
            Pen blackPen = new Pen(Color.Black, 1);
            g.DrawArc(blackPen, x, y, height, width, startAngle, sweepAngle);
        }
    }
}
