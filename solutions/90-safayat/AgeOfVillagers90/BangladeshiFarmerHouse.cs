using System.Drawing;

namespace AgeOfVillagers90
{
    public class BangladeshiFarmerHouse : CompositeShape
    {
        public BangladeshiFarmerHouse(Point mainPoint)
        {
            Point recPoint1 = new Point(mainPoint.X - 8, mainPoint.Y + 8);
            Point recPoint2 = new Point(mainPoint.X + 8, mainPoint.Y + 16);
            Point triPoint = new Point(mainPoint.X + 8, mainPoint.Y + 8);

            AddComponent(new Rectangle(recPoint1, recPoint2));
            AddComponent(new TAngle(mainPoint, recPoint1, triPoint));
        }
    }
}
