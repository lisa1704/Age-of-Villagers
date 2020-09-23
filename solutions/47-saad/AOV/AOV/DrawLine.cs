using System.Drawing;

namespace AOV
{
    class DrawLine : IDraw
    {
        private Point x;
        private Point y;

        public DrawLine(Point x, Point y)
        {
            this.x = x;
            this.y = y;
        }
        public void draw(Graphics g)
        {
            Pen blackPen = new Pen(Color.Black, 1);
            g.DrawLine(blackPen, x, y);
        }
    }
}
