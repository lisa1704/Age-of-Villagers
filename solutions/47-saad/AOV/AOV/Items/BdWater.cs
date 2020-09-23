using System.Drawing;

namespace AOV
{
    public class BdWaterSource : NationItem
    {
        private readonly Point _clicked;
        public BdWaterSource(Point clicked)
        {
            _clicked = clicked;
            Point x2 = new Point(_clicked.X + 5, _clicked.Y - 2);
            Point x3 = new Point(_clicked.X + 6, _clicked.Y);
            Point x4 = new Point(_clicked.X + 12, _clicked.Y - 5);
            Point x5 = new Point(_clicked.X + 19, _clicked.Y);
            Point x6 = new Point(_clicked.X + 17, _clicked.Y + 9);
            Point x7 = new Point(_clicked.X + 7, _clicked.Y + 5);
            Point x8 = new Point(_clicked.X, _clicked.Y + 11);
            Point x9 = new Point(_clicked.X - 5, _clicked.Y + 7);

            nationItemShape = new BdWaterSourceShape(_clicked, x2, x3, x4, x5, x6, x7, x8, x9);
        }
        public override Point GetPoint()
        {
            return _clicked;
        }
    }
}
