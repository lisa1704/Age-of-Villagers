using System.Drawing;

namespace ageOfVillagers
{
    internal class Bdwater : IShape
    {
        private int xLength = 24;
        private int yLength = 16;
        Pen p = new Pen(Color.Green);
        public string draw(int x, int y, Graphics g)
        {
            Line l1 = new Line(x - 12, y, x - 6, y + 6);
            l1.Draw(g,p);
            Line l2 = new Line(x - 6, y + 6, x - 2, y + 7);
            l2.Draw(g,p);
            Line l3 = new Line(x - 2, y + 7, x - 1, y + 3);
            l3.Draw(g,p);
            Line l4 = new Line(x - 1, y + 3, x + 6, y + 8);
            l4.Draw(g,p);
            Line l5 = new Line(x + 6, y + 8, x + 12, y + 2);
            l5.Draw(g,p);
            Line l6 = new Line(x + 12, y + 2, x + 5, y - 7);
            l6.Draw(g,p);
            Line l7 = new Line(x + 5, y - 7, x - 1, y - 2);
            l7.Draw(g,p);
            Line l8 = new Line(x - 1, y - 2, x - 6, y + 8);
            l8.Draw(g,p);
            Line l9 = new Line(x - 6, y + 8, x - 12, y);
            l9.Draw(g,p);
            return "Drawing BD water";
        }
    }
}