using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianHouse : VillageItem
    {
        private readonly Point _point;

        public EgyptianHouse(Point point)
        {
            _point = point;
            villageItemShape = new EgyptianHouseShape(new Point(_point.X - 8, _point.Y - 8), new Point(_point.X + 8, _point.Y + 8));
        }

        public override Point GetPoint()
        {
            return _point;
        }
    }
}
