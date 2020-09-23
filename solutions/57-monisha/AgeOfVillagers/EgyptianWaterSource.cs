using System.Drawing;
using static AgeOfVillagers.ShapeArc;

namespace AgeOfVillagers
{
    public class EgyptianWaterSource : CompositeShape
    {
        public EgyptianWaterSource(Point MPt)
        {
            Point topPt = new Point(MPt.X + 12, MPt.Y + 12);

            AddComp(new ShapeEllipse(MPt, topPt));

        }
    }
}
