using System.Drawing;

namespace ageOfVillagers
{
    internal class Circle
    {
        private int x, y, radius;
        Graphics g;
        Pen p;
        public Circle(Graphics g,Pen p,int x, int y, int radius)
        {
            this.g = g;
            this.p = p;
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public string Draw()
        {
            return "Drawing a circle. ";
        }
    }
}