using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianWell : VillageItem
    {
        private readonly Point _point;

        public EgyptianWell(Point point)
        {
            _point = point;
            villageItemShape = new WellShape(new Point(_point.X - 6, _point.Y - 6), new Point(_point.X + 6, _point.Y + 6));
        }

        public override Point GetPoint()
        {
            return _point;
        }
    }
}
