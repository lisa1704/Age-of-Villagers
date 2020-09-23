using System.Drawing;

namespace AOV
{
    public class BdHouse : VillageItem
    {
        private readonly Point _clicked;

        public BdHouse(Point clicked)
        {
            _clicked = clicked;
            Point x1 = new Point(_clicked.X - 8, _clicked.Y + 8);
            Point x2 = new Point(_clicked.X + 8, _clicked.Y + 8);
            Point topLeftCorner = new Point(_clicked.X - 8, _clicked.Y);
            Point bottomRightCorner = new Point(_clicked.X + 8, _clicked.Y + 16);

            villageItemShape = new BdHouseShape(clicked, x1, x2, topLeftCorner, bottomRightCorner);
        }
        public override Point GetPoint()
        {
            return _clicked;
        }
    }
}
