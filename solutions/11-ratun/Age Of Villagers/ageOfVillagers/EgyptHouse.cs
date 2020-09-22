using System.Drawing;

namespace ageOfVillagers
{
    internal class EgyptHouse : IShape
    {
        readonly Pen p = new Pen(Color.Yellow);
        public string draw(int x, int y, Graphics g)
        {
            Triangle t1 = new Triangle(g,p,x, y + 8, x - 8, y - 4, x + 2, y - 8);
            t1.Draw();
            Triangle t2 = new Triangle(g,p,x, y + 8, x + 8, y, x + 2, y - 8);
            t2.Draw();
            return "drawing egypt house";
        }
    }
}