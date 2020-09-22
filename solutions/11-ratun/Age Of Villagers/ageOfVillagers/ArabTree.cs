using System.Drawing;

namespace ageOfVillagers
{
    internal class ArabTree : IShape
    {
        Pen p = new Pen(Color.LightYellow);
        public string draw(int x, int y, Graphics g)
        {
            Rectangle r = new Rectangle(g,p,x - 1, y, x - 1, y - 12, x + 1, y - 12, x + 1, y);
            Line l1 = new Line(x, y, x - 8, y + 4);
            Line l2 = new Line(x, y, x - 4, y + 8);
            Line l3 = new Line(x, y, x, y + 12);
            Line l4 = new Line(x, y, x + 4, y + 8);
            Line l5 = new Line(x, y, x + 8, y + 4);
            return "Drawing Arab Tree";
        }
    }
}