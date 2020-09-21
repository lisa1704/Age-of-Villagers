using System.Drawing;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class EgyptWater : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Circle circle = new Circle(g, pen, point, 50, 50, 0, 360);
            circle.DrawShape();
        }
    }
}
