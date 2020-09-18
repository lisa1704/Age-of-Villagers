using System.Drawing;

namespace AgeOfVillagers90
{
    public class BangladeshiFarmersWaterSource : CompositeShape
    {
        public BangladeshiFarmersWaterSource(Point mainPoint)
        {
            Point point1 = new Point(mainPoint.X - 3, mainPoint.Y + 2);
            Point point2 = new Point(mainPoint.X - 8 , mainPoint.Y + 10);
            Point point3 = new Point(mainPoint.X - 2, mainPoint.Y + 16);
            Point point4 = new Point(mainPoint.X , mainPoint.Y + 12);
            Point point5 = new Point(mainPoint.X + 5, mainPoint.Y + 16);
            Point point6 = new Point(mainPoint.X + 16, mainPoint.Y + 8);
            Point point7 = new Point(mainPoint.X + 7 , mainPoint.Y );
            Point point8 = new Point(mainPoint.X + 3, mainPoint.Y + 4);

            AddComponent(new Line(mainPoint, point1));
            AddComponent(new Line(point1, point2));
            AddComponent(new Line(point2, point3));
            AddComponent(new Line(point3, point4));
            AddComponent(new Line(point4, point5));
            AddComponent(new Line(point5, point6));
            AddComponent(new Line(point6, point7));
            AddComponent(new Line(point7, point8));
           AddComponent(new Line(point8, mainPoint));
        }
    }
}
