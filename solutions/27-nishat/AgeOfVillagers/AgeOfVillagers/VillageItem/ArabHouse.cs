using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabHouse : VillageItem
    {
        private readonly Point _point;

        public ArabHouse(Point point)
        {
            _point = point;
            villageItemShape = new ArabHouseShape(new Point(_point.X - 8, _point.Y - 8), new Point(_point.X + 8, _point.Y + 8));
        }

        public override Point GetPoint()
        {
            return _point;
        }
    }
}
