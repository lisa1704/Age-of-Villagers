using System.Drawing;

namespace AOV
{
    public class EgyptHouse : NationItem
    {
        private readonly Point _clicked;
        public EgyptHouse(Point clicked)
        {
            _clicked = clicked;
            Point x1 = new Point(_clicked.X - 7, _clicked.Y + 13);
            Point x2 = new Point(_clicked.X + 4, _clicked.Y + 16);
            Point x3 = new Point(x1.X + 16, _clicked.Y + 11);

            Point topLeftCorner = new Point(_clicked.X - 7, _clicked.Y);
            Point bottomRightCorner = new Point(_clicked.X + 9, _clicked.Y + 16);

            villageItemShape = new EgyptHouseShape(_clicked, x1, x2, x3, topLeftCorner, bottomRightCorner);
        }
        public override Point GetPoint()
        {
            return _clicked;
        }
    }
}
