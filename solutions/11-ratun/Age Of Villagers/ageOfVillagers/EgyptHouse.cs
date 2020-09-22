using System.Drawing;

namespace ageOfVillagers
{
    internal class EgyptHouse : IShape
    {
        Pen p = new Pen(Color.Yellow);
        public string draw(int x, int y, Graphics g)
        {
            Triangle t1 = new Triangle(g,p,x, y + 8, x - 8, y - 4, x + 2, y - 8);
            Triangle t2 = new Triangle(g,p,x, y + 8, x + 8, y, x + 2, y - 8);
            return t1.Draw() + t2.Draw();
        }
    }
}