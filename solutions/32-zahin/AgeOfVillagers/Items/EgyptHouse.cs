using System.Drawing;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers.Items
{
    class EgyptHouse : IItem
    {
        Pen pen = new Pen(Color.Black);
        public void Draw(Graphics g, Point point)
        {
            Point trianglepoint1 = new Point(point.X + 10, point.Y + 1);
            Point trianglepoint2 = new Point(point.X + 8, point.Y - 15);
            Point trianglepoint3 = new Point(point.X + 15, point.Y - 5);
            Triangle triangle1 = new Triangle(g, pen, point, trianglepoint1, trianglepoint2);
            triangle1.DrawShape();
            Triangle triangle2 = new Triangle(g, pen, trianglepoint1, trianglepoint2, trianglepoint3);
            triangle2.DrawShape();
        }
    }
}
