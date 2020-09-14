using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabTree : VillageItem
    {
        private readonly Point _point;

        public ArabTree(Point point)
        {
            _point = point;
            villageItemShape = new ArabTreeShape(new Point(_point.X - 8, _point.Y - 12), new Point(_point.X + 8, _point.Y + 12));
        }

        public override Point GetPoint()
        {
            return _point;
        }
    }
}
