using System.Drawing;

namespace AgeOfVillagers
{
    public class NoWaterResource : VillageItem
    {
        private readonly Point _point;

        public NoWaterResource(Point point)
        {
            _point = point;
        }

        public override Point GetPoint()
        {
            return _point;
        }
    }
}
