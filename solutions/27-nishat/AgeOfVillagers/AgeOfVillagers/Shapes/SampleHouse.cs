using System.Drawing;

namespace AgeOfVillagers
{
    public class SampleHouse : VillageItem
    {
        private readonly Point point;

        public SampleHouse(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, point, new Point(point.X + 50, point.Y - 50));
        }

        public override Point GetPoint()
        {
            return point;
        }
    }

}
