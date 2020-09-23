using System.Drawing;

namespace AgeOfVillagers90
{
    public class EgyptianHouse : CompositeShape
    {
        public EgyptianHouse(Point mainPoint)
        {
            Point topPoint1 = new Point(mainPoint.X - 6, mainPoint.Y + 14);
            Point topPoint2 = new Point(mainPoint.X + 2, mainPoint.Y + 16);
            Point topPoint3 = new Point(mainPoint.X + 8, mainPoint.Y+12);


            AddComponent(new TAngle(topPoint2, topPoint1, mainPoint));
            AddComponent(new TAngle(topPoint3, topPoint2, mainPoint));
        }
    }
}
