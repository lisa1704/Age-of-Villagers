using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianTree : VillageItem
    {
        private readonly Point point;

        public EgyptianTree(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            Shape tree = new EgyptianTreeShape(new Point(point.X - 8, point.Y - 12), new Point(point.X + 8, point.Y + 12));
            tree.Draw(g, p);
        }

        public override Point GetPoint()
        {
            return point;
        }
    }
}
