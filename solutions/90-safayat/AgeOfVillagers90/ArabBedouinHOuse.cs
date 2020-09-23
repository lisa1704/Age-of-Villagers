using System.Drawing;

namespace AgeOfVillagers90
{
    public class ArabBedouinHOuse : CompositeShape
    {
        public ArabBedouinHOuse(Point mainPoint)
        {
            Point topPoint1 = new Point(mainPoint.X - 4, mainPoint.Y + 10);
            Point topPoint2 = new Point(mainPoint.X + 4, mainPoint.Y + 10);
            Point topPoint3 = new Point(mainPoint.X + 12, mainPoint.Y + 4);
            Point topPoint4 = new Point(mainPoint.X + 8, mainPoint.Y - 6);


            AddComponent(new TAngle(topPoint2, topPoint1, mainPoint));
            AddComponent(new Line(topPoint4, mainPoint));
            AddComponent(new Line(topPoint4, topPoint3));
            AddComponent(new Line(topPoint3, topPoint2));


        }
    }
}
