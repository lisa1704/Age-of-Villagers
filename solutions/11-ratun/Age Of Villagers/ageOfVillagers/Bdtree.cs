using System.Drawing;

namespace ageOfVillagers
{
    internal class Bdtree : IShape
    {
        Pen pen = new Pen(Color.Green);
        public string draw(int x, int y, Graphics g)
        {
            Circle c = new Circle(g,pen, x, y + 2, 8);
            Rectangle r = new Rectangle(g,pen, x - 1, y, x + 1, y, x + 1, y - 12, x - 1, y - 12);
            return "Drawing BD tree";
        }
    }
}