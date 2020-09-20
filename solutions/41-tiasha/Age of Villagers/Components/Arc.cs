using Age_of_Villagers;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Arc : IComponent
    {
        public int x, y, width, height, startAngle, sweepAngle;

        public Arc(int x, int y, int width, int height, int startAngle, int sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawArc(pen, x, y, width, height, startAngle, sweepAngle);
        }
    }
}
