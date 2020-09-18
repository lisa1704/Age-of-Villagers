using System.Drawing;

namespace AgeOfVillagers90
{
    public class InuitHouse : CompositeShape
    {
        public InuitHouse(Point mainPoint)
        {
            Point linePoint1 = new Point(mainPoint.X , mainPoint.Y + 8);
            Point linePoint2 = new Point(mainPoint.X + 16, mainPoint.Y + 8);

            AddComponent(new Line(linePoint2, linePoint1));
            AddComponent(new ArcShape(mainPoint.X, mainPoint.Y, 16F, 16F, 0, -180.0F));
            AddComponent(new ArcShape(mainPoint.X + 4, mainPoint.Y + 4, 8F, 8F, 0, -180.0F));
        }
    }
}
