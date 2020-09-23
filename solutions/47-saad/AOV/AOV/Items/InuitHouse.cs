using System.Drawing;

namespace AOV
{
    public class InuitHouse : NationItem
    {
        private readonly Point _clicked;
        public InuitHouse(Point clicked)
        {
            _clicked = clicked;
            Point x2 = new Point(_clicked.X + 16, _clicked.Y);
            Point x3 = new Point(_clicked.X + 16, _clicked.Y + 16);
            Point x4 = new Point(_clicked.X , _clicked.Y + 16);

            villageItemShape = new InuitHouseShape(_clicked, x2, x3, x4);            
        }
        public override Point GetPoint()
        {
            return _clicked;
        }
    }
}
