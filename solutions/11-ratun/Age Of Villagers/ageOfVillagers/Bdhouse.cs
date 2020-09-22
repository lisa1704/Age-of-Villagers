using System.Drawing;

namespace ageOfVillagers
{
    internal class Bdhouse : IShape
    {
        public string draw(int x, int y, Graphics g)
        {
            Triangle t = new Triangle(Graphics g,x, y + 12, x - 12, y, x + 12, y);
            Rectangle r = new Rectangle(Graphics g,x - 12, y, x + 12, y, x + 12, y - 12, x - 12, y - 12);
            return "Drawing bd house";
        }
    }
}