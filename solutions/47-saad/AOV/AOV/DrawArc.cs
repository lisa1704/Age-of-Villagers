using System.Drawing;

namespace AOV
{
    class DrawArc : IDraw
    {
        private float x;
        private float y;
        private float height;
        private float width;
        private float startAngle;
        private float sweepAngle;

        public DrawArc(float x, float y, float height, float width, float startAngle, float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }
        public void draw(Graphics g)
        {
            Pen blackPen = new Pen(Color.Black, 1);
            g.DrawArc(blackPen, x, y, height, width, startAngle, sweepAngle);
        }
    }
}
