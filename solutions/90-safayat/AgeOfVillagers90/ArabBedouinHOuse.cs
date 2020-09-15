using System.Drawing;

namespace AgeOfVillagers90
{
    public class ArabBedouinHOuse : CompositeShape
    {
        public ArabBedouinHOuse(Point mainPoint)
        {
            Point topPoint1 = new Point(mainPoint.X - 24, mainPoint.Y + 50);
            Point topPoint2 = new Point(mainPoint.X + 16, mainPoint.Y + 50);
            Point topPoint3 = new Point(mainPoint.X + 25, mainPoint.Y - 30);
            Point topPoint4 = new Point(topPoint2.X + 25, topPoint2.Y - 30);


            AddComponent(new TAgle(topPoint2, topPoint1, mainPoint));
            AddComponent(new Line(topPoint3, mainPoint));
            AddComponent(new Line(topPoint2, topPoint4));
            AddComponent(new Line(topPoint3, topPoint4));


        }
    }
}
