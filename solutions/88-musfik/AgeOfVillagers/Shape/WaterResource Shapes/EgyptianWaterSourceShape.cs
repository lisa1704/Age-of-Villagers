using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianWaterSourceShape : CompositeShape
    {
        public EgyptianWaterSourceShape(Point center)
        {
            Point Circle_topLeft = new Point(center.X - 6, center.Y - 6);
            Point Circle_bottomRight = new Point(center.X + 6, center.Y + 6);

            AddComponent(new Arc(Circle_topLeft, Circle_bottomRight, 0, 360));
        }
    }
}
