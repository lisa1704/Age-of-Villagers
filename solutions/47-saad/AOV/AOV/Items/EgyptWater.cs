using System.Drawing;

namespace AOV
{
    public class EgyptWater : NationItem

    {
        private readonly Point _clicked;
        public EgyptWater(Point clicked)
        {
            _clicked = clicked;
            Point p = new Point(_clicked.X + 12, _clicked.Y + 12);

            villageItemShape = new EgyptWaterShape(_clicked, p);
        }
        public override Point GetPoint()
        {
            return _clicked;
        }
    }
}
