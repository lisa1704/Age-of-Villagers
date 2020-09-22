using System.Drawing;

namespace ageOfVillagers
{
    internal class Bdhouse : IShape
    {
        Pen pen = new Pen(Color.Green);
        public string draw(int x, int y, Graphics g)
        {
            Triangle t = new Triangle(Graphics g,pen,x, y + 12, x - 12, y, x + 12, y);
            Rectangle r = new Rectangle(Graphics g,pen,x - 12, y, x + 12, y, x + 12, y - 12, x - 12, y - 12);
            return "Drawing bd house";
        }
    }
}