using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiTree : VillageItem
    {
        private readonly Point point;

        public BangladeshiTree(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            Shape tree = new BangladeshiTreeShape(new Point(point.X-8, point.Y - 12), new Point(point.X + 8, point.Y+12));
            tree.Draw(g, p);
        }

        public override Point GetPoint()
        {
            return point;
        }
    }
}
