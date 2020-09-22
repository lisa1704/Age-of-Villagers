using System.Drawing;

namespace ageOfVillagers
{
    internal class Bdtree : IShape
    {
        private string drawing = "";
        public string draw(int x, int y, Graphics g)
        {
            Circle c = new Circle(Graphics g, x, y + 2, 8);
            Rectangle r = new Rectangle(Graphics g, x - 1, y, x + 1, y, x + 1, y - 12, x - 1, y - 12);
            return "Drawing BD tree";
        }
    }
}