using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabHouseShape : CompositeShape
    {
        public ArabHouseShape(Point point)
        {
            Point FrontTop = new Point(point.X - 0, point.Y + 6);
            Point baseFrontLeft = new Point(point.X - 8, point.Y + 6);
            Point baseFrontRight = new Point(point.X - 6, point.Y - 6);
            Point baseBackRight = new Point(point.X + 2, point.Y - 10);
            Point baseBackTop = new Point(point.X + 8, point.Y + 2);

            AddComponent(new VShape(FrontTop, baseFrontLeft, baseFrontRight));
            AddComponent(new Rectangle(FrontTop, baseFrontRight, baseBackRight, baseBackTop));
        }
    }
}
