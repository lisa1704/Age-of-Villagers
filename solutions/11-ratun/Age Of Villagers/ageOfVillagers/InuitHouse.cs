using System.Drawing;

namespace ageOfVillagers
{
    internal class InuitHouse : IShape
    {
        Pen p = new Pen(Color.Pink);
        public string draw(int x, int y, Graphics g)
        {
            HalfCircle h1 = new HalfCircle(g,p,x, y, 8);
            HalfCircle h2 = new HalfCircle(g,p,x, y, 2);
            return "Drawing Inuit House";
        }
    }
}