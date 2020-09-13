using System.Drawing;

namespace AgeOfVillagers
{
    public class SampleWaterResource : VillageItem
    {
        private readonly Point point;

        public SampleWaterResource(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, point, new Point(point.X + 50, point.Y));
        }

        public override Point GetPoint()
        {
            return point;
        }
    }

}
