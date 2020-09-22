using System.Drawing;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class EgyptWater : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point center = new Point(point.X + 12, point.Y + 12);
            Circle circle = new Circle(g, pen, center, 24, 24, 0, 360);
            circle.DrawShape();
        }
    }
}
