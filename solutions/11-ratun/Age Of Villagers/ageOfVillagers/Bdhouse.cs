using System.Drawing;

namespace ageOfVillagers
{
    internal class Bdhouse : IShape
    {
        readonly Pen pen = new Pen(Color.Green);
        public void draw(int x, int y, Graphics g)
        {
            Triangle t = new Triangle(g,pen,x, y + 12, x - 12, y, x + 12, y);
            t.Draw();
            Rectangle r = new Rectangle(g,pen,x - 12, y, x + 12, y, x + 12, y - 12, x - 12, y - 12);
            r.Draw();
            //return "Drawing bd house";
        }
    }
}