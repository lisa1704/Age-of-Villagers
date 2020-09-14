using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiHouse : VillageItem
    {
        private readonly Point _point;

        public BangladeshiHouse(Point point)
        {
            _point = point;
            villageItemShape = new BangladeshiHouseShape(new Point(_point.X, _point.Y - 8), new Point(_point.X-8, _point.Y), new Point(_point.X+8, _point.Y + 8));
        }

        public override Point GetPoint()
        {
            return _point;
        }
    }
}
