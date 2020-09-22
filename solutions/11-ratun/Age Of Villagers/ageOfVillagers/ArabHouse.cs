using System.Drawing;

namespace ageOfVillagers
{
    internal class ArabHouse : IShape
    {
        readonly Pen p = new Pen(Color.LightYellow);
        public void draw(int x, int y, Graphics g)
        {
            Triangle t = new Triangle(g,p,x - 2, y + 6, x - 8, y - 8, x + 2, y - 8);
            t.Draw();
            Rectangle r = new Rectangle(g,p,x - 2, y + 6, x + 2, y - 8, x + 8, y - 6, x + 1, y + 8);
            r.Draw();
            //return "Drawing Arab House";
        }
    }
}