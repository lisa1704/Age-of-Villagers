using System.Drawing;

namespace AgeOfVillagers90
{
    public class EgyptianHouse : CompositeShape
    {
        public EgyptianHouse(Point mainPoint)
        {
            Point topPoint1 = new Point(mainPoint.X - 24, mainPoint.Y + 50);
            Point topPoint2 = new Point(mainPoint.X + 16, mainPoint.Y + 50);
            Point topPoint3 = new Point(mainPoint.X + 35, mainPoint.Y+40);
            Point topPoint4 = new Point(mainPoint.X + 25, mainPoint.Y + 50);

            AddComponent(new TAgle(topPoint2, topPoint1, mainPoint));
            AddComponent(new TAgle(topPoint3, topPoint2, mainPoint));
        }
    }
}
