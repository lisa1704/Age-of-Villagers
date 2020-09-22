using System.Drawing;

namespace ageOfVillagers
{
    internal class Bdhouse : IShape
    {
        public string draw(int x, int y, Graphics g)
        {
            Triangle t = new Triangle(x, y + 12, x - 12, y, x + 12, y);
            Rectangle r = new Rectangle(x - 12, y, x + 12, y, x + 12, y - 12, x - 12, y - 12);
            return t.Draw() + r.Draw();
        }
    }
}