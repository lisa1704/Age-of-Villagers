using System.Drawing;

namespace AgeOfVillagers90
{
    public class EgytianWaterSource : CompositeShape
    {
        public EgytianWaterSource(Point mainPoint)
        {
            Point topPoint = new Point(mainPoint.X + 12, mainPoint.Y+ 12);
            AddComponent(new ShapeEllipse(mainPoint, topPoint));
        }
    }
}
