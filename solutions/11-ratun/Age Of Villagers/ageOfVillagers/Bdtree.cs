using System.Drawing;

namespace ageOfVillagers
{
    internal class Bdtree : IShape
    {
        readonly Pen pen = new Pen(Color.Green);
        public string draw(int x, int y, Graphics g)
        {
            Circle c = new Circle(g,pen, x, y + 2, 8);
            c.Draw();
            Rectangle r = new Rectangle(g,pen, x - 1, y, x + 1, y, x + 1, y - 12, x - 1, y - 12);
            r.Draw();
            return "Drawing BD tree";
        }
    }
}