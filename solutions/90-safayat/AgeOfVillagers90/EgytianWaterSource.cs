using System.Drawing;

namespace AgeOfVillagers90
{
    public class EgytianWaterSource : CompositeShape
    {
        public EgytianWaterSource(Point mainPoint)
        {
            Point topPoint = new Point(mainPoint.X + 75, mainPoint.Y+ 75);
            AddComponent(new ShapeEllipse(mainPoint, topPoint));
        }
    }
}
