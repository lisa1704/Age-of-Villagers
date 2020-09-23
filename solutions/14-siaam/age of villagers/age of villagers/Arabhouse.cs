using System.Drawing;

namespace age_of_villagers
{
    class Arabhouse : IComplexShape
    {
        Pen pen = new Pen(Color.Blue);
        public void drawComponent(Graphics g, Point p)
        {
            Point trianglePoint1 = new Point(p.X + 16, p.Y + 20);
            Point trianglePoint2 = new Point(p.X - 16, p.Y + 20);
            
            Triangle triangle = new Triangle(trianglePoint2, trianglePoint1,p);
            triangle.draw(g,pen);

            Point rectanglePoint1 = new Point(p.X + 13, p.Y - 10);
            Point rectanglePoint2 = new Point(p.X + 28, p.Y + 10);

            Rectangle rectangle = new Rectangle(p,rectanglePoint1,rectanglePoint2, trianglePoint1);
            rectangle.draw(g, pen);


        }
    }


}
