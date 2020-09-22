using System.Drawing;

namespace ageOfVillagers
{
    internal class InuitHouse : IShape
    {
        readonly Pen p = new Pen(Color.Pink);
        public string draw(int x, int y, Graphics g)
        {
            HalfCircle h1 = new HalfCircle(g,p,x, y, 8);
            h1.Draw();
            HalfCircle h2 = new HalfCircle(g,p,x, y, 2);
            h2.Draw();
            Line l1 = new Line(g, p, x - 8, y - 8, x + 8, y - 8);
            l1.Draw();
            return "Drawing Inuit House";
        }
    }
}