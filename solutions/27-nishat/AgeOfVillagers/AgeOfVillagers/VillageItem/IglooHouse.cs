using System.Drawing;

namespace AgeOfVillagers
{
    public class IglooHouse : VillageItem
    {
        private readonly Point _point;

        public IglooHouse(Point point)
        {
            _point = point;
            villageItemShape = new IglooShape(new Point(_point.X - 8, _point.Y - 8), new Point(_point.X + 8, _point.Y + 8));
        }

        public override Point GetPoint()
        {
            return _point;
        }
    }
}
