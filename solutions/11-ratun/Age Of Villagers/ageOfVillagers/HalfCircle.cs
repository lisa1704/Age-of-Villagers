using System.Drawing;

namespace ageOfVillagers
{
    internal class HalfCircle
    {
        private readonly int x, y, radius;
        private int XupperLeft, YupperLeft, height, width;
        readonly Graphics g;
        readonly Pen p;
        public HalfCircle(Graphics g, Pen p,int x, int y, int radius)
        {
            this.g = g;
            this.p = p;
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public void Draw()
        {
            XupperLeft = x - radius;
            YupperLeft = y - (radius/2);
            height = 2 * radius;
            width = 2 * radius;
            Arc a = new Arc(g, p, XupperLeft, YupperLeft, height, width, 0, 180);
            a.Draw();
        }
    }
}