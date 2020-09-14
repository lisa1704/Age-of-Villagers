using System.Drawing;

namespace AgeOfVillagers
{
    public class NoTree : VillageItem
    {
        private readonly Point _point;

        public NoTree(Point point)
        {
            _point = point;
        }

        public override Point GetPoint()
        {
            return _point;
        }
    }
}
