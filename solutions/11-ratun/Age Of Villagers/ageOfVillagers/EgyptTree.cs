using System.Drawing;

namespace ageOfVillagers
{
    internal class EgyptTree : IShape
    {
        readonly Pen p = new Pen(Color.Yellow);
        public string draw(int x, int y, Graphics g)
        {
            Line l1 = new Line(g,p,x, y - 12, x - 6, y + 10);
            l1.Draw();
            Line l2 = new Line(g,p,x, y - 12, x + 6, y + 10);
            l2.Draw();
            Line l3 = new Line(g,p,x - 5, y + 8, x - 8, y + 6);
            l3.Draw();
            Line l4 = new Line(g,p,x - 5, y + 8, x - 2, y + 12);
            l4.Draw();
            Line l5 = new Line(g,p,x + 5, y + 8, x + 8, y + 6);
            l5.Draw();
            Line l6 = new Line(g,p,x + 5, y + 8, x + 2, y + 12);
            l6.Draw();
            return "Drawing egypt tree";
        }
    }
}