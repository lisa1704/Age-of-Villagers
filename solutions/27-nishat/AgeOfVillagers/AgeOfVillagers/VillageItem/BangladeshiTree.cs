using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiTree : VillageItem
    {
        private readonly Point _point;

        public BangladeshiTree(Point point)
        {
            _point = point;
            villageItemShape = new BangladeshiTreeShape(new Point(_point.X-8, _point.Y - 12), new Point(_point.X + 8, _point.Y+12));
        }

        public override Point GetPoint()
        {
            return _point;
        }
    }
}
