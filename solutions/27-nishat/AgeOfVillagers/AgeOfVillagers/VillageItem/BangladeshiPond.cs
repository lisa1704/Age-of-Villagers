using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiPond : VillageItem
    {
        private readonly Point _point;

        public BangladeshiPond(Point point)
        {
            _point = point;
            villageItemShape = new BangladeshiPondShape(new Point(_point.X - 12, _point.Y - 8), new Point(_point.X + 12, _point.Y + 8));
        }

        public override Point GetPoint()
        {
            return _point;
        }
    }
}
