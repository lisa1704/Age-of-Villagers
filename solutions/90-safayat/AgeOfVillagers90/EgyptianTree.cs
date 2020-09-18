using System.Drawing;

namespace AgeOfVillagers90
{
    public class EgyptianTree : CompositeShape
    {
        public EgyptianTree(Point mainPoint)
        {
            
            Point point1 = new Point(mainPoint.X - 5, mainPoint.Y - 24);
            Point point2 = new Point(mainPoint.X + 5, mainPoint.Y - 24);
            Point point3 = new Point(mainPoint.X - 2, mainPoint.Y - 24);
            Point point4 = new Point(mainPoint.X + 2, mainPoint.Y - 24);
            Point point5 = new Point(mainPoint.X + 8, mainPoint.Y - 24);
            Point point6 = new Point(mainPoint.X - 8, mainPoint.Y - 24);
            Point point7 = new Point(mainPoint.X - 3, mainPoint.Y - 12);
            Point point8 = new Point(mainPoint.X + 3, mainPoint.Y - 12);

            AddComponent(new Line(mainPoint, point1));
            AddComponent(new Line(mainPoint, point2));
            AddComponent(new Line(point3, point7));
            AddComponent(new Line(point6, point7));
           AddComponent(new Line(point4, point8));
           AddComponent(new Line(point5, point8));
        }
    }
}
