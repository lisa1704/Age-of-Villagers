using System.Drawing;

namespace AgeOfVillagers
{
    class EgyptianKingsWaterSource : Composite
    {
        public EgyptianKingsWaterSource(Point point)
        {
            Point topPoint = new Point(point.X + 12, point.Y + 12);
            AddComponent(new Ellipse(point, topPoint));
        }
    }
}