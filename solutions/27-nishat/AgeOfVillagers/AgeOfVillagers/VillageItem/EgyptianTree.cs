using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianTree : VillageItem
    {
        private readonly Point _point;

        public EgyptianTree(Point point)
        {
            _point = point;
            villageItemShape = new EgyptianTreeShape(new Point(_point.X - 8, _point.Y - 12), new Point(_point.X + 8, _point.Y + 12));
        }

        public override Point GetPoint()
        {
            return _point;
        }
    }
}
