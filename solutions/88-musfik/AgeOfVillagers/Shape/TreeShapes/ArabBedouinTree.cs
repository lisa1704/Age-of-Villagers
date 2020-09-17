using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabBedouinTree : CompositeShape
    {
        public ArabBedouinTree(Point point)
        {
            Point TopLeft = new Point(point.X - 1, point.Y);
            Point BottomRight = new Point(point.X + 1, point.Y + 12);

            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Line(point, new Point(point.X + 9, point.Y - 4)));
            AddComponent(new Line(point, new Point(point.X - 9, point.Y - 4)));
            AddComponent(new Line(point, new Point(point.X + 5, point.Y - 10)));
            AddComponent(new Line(point, new Point(point.X - 5, point.Y - 10)));
            AddComponent(new Line(point, new Point(point.X , point.Y - 12)));
        }
    }
}
