using System.Drawing;

namespace ageOfVillagers
{
    internal class Circle
    {
        private int x, y, radius;
        public Circle(Graphics g,Pen p,int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public string Draw(Graphics g, Pen p)
        {
            return "Drawing a circle. ";
        }
    }
}