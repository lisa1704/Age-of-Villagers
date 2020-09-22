using System.Drawing;

namespace ageOfVillagers
{
    internal class Line
    {
        Graphics g;
        Pen p;
        private int x1, y1, x2, y2;
        public Line(Graphics g, Pen p,int x1, int y1, int x2, int y2)
        {
            this.g = g;
            this.p = p;
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public void Draw()
        {
            g.DrawLine(p, x1, y1, x2, y2);
            //return "Drawing a line. ";
        }
    }
}