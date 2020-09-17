using System.Drawing;

namespace AgeOfVillagers
{
    public class InuitHuntersHouse : CompositeShape
    {
        public InuitHuntersHouse(Point center)
        {
            Point innerCircle_topLeft = new Point(center.X - 3, center.Y - 6);
            Point innerCircle_bottomRight = new Point(center.X + 3, center.Y + 6);
            Point outerCircle_topLeft = new Point(center.X - 8, center.Y - 14);
            Point outerCircle_bottomRight = new Point(center.X + 8, center.Y + 14);

            AddComponent(new Arc(innerCircle_topLeft, innerCircle_bottomRight, 0, -180));
            AddComponent(new Arc(outerCircle_topLeft, outerCircle_bottomRight, 0, -180));
            AddComponent(new Line(new Point(center.X - 8, center.Y), new Point(center.X + 8, center.Y)));
        }
    }
}
