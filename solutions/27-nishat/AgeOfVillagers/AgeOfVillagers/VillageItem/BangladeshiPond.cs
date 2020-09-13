using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiPond : VillageItem
    {
        private readonly Point point;

        public BangladeshiPond(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            Shape watersource = new BangladeshiPondShape(new Point(point.X - 12, point.Y - 8), new Point(point.X + 12, point.Y + 8));
            watersource.Draw(g, p);
        }

        public override Point GetPoint()
        {
            return point;
        }
    }
}
