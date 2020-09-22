using System.Drawing;

namespace ageOfVillagers
{
    internal class InuitHouse : IShape
    {
        public string draw(int x, int y, Graphics g)
        {
            HalfCircle h1 = new HalfCircle(x, y, 8);
            HalfCircle h2 = new HalfCircle(x, y, 2);
            return h1.Draw() + h2.Draw();
        }
    }
}