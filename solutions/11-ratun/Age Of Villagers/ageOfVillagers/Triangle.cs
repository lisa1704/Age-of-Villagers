using System.Drawing;

namespace ageOfVillagers
{
    internal class Triangle
    {
        readonly Graphics g;
        readonly Pen p;
        private readonly int x1, y1, x2, y2, x3, y3;
        public Triangle(Graphics g, Pen p, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.g = g;
            this.p = p;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }
        public void Draw()
        {
            Line l1 = new Line(g,p,x1, y1, x2, y2);
            Line l2 = new Line(g,p,x2, y2, x3, y3);
            Line l3 = new Line(g,p,x3, y3, x1, y1);
            l1.Draw();
            l2.Draw();
            l3.Draw();
        }
    }
}