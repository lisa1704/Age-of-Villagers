using System.Drawing;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class EgyptHouse : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point trianglepoint1 = new Point(point.X + 50, point.Y + 25);
            Point trianglepoint2 = new Point(point.X + 50, point.Y - 75);
            Point trianglepoint3 = new Point(point.X + 100, point.Y - 25);
            Triangle triangle1 = new Triangle(g, pen, point, trianglepoint1, trianglepoint2);
            triangle1.DrawShape();
            Triangle triangle2 = new Triangle(g, pen, trianglepoint1, trianglepoint2, trianglepoint3);
            triangle2.DrawShape();
        }
    }
}
