using System.Drawing;

namespace ageOfVillagers
{
    internal class Arc
    {
        Graphics g;
        Pen p;
        private int x, y, height, width, startAngle, finishAngle;
        public Arc(Graphics g, Pen p, int x, int y, int height, int width, int startAngle, int finishAngle)
        {
            this.g = g;
            this.p = p;
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.startAngle = startAngle;
            this.finishAngle = finishAngle;
        }
        public void Draw()
        {
            g.DrawArc(p, x, y, width, height, startAngle, finishAngle);
            //return "Drawing an Arc. ";
        }
    }
}
