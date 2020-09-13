using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabTree : VillageItem
    {
        private readonly Point point;

        public ArabTree(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            Shape tree = new ArabTreeShape(new Point(point.X - 8, point.Y - 12), new Point(point.X + 8, point.Y + 12));
            tree.Draw(g, p);
        }

        public override Point GetPoint()
        {
            return point;
        }
    }
}
