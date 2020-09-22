using System.Drawing;

namespace ageOfVillagers
{
    internal class EgyptWater : IShape
    {
        private int Xaxis = 16;
        private int Yaxis = 16;
        Pen p = new Pen(Color.Yellow);
        public string draw(int x, int y, Graphics g)
        {
            Circle c = new Circle(g,p,x, y, 8);
            return c.Draw(g,p);
        }
    }
}