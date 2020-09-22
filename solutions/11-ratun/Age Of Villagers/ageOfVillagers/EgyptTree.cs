using System.Drawing;

namespace ageOfVillagers
{
    internal class EgyptTree : IShape
    {
        Pen p = new Pen(Color.Yellow);
        public string draw(int x, int y, Graphics g)
        {
            Line l1 = new Line(x, y - 12, x - 6, y + 10);
            l1.Draw(g, p);
            Line l2 = new Line(x, y - 12, x + 6, y + 10);
            l2.Draw(g, p);
            Line l3 = new Line(x - 5, y + 8, x - 8, y + 6);
            l3.Draw(g, p);
            Line l4 = new Line(x - 5, y + 8, x - 2, y + 12);
            l4.Draw(g, p);
            Line l5 = new Line(x + 5, y + 8, x + 8, y + 6);
            l5.Draw(g, p);
            Line l6 = new Line(x + 5, y + 8, x + 2, y + 12);
            l6.Draw(g, p);
            return "Drawing egypt tree";
        }
    }
}