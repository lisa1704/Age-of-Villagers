using System.Drawing;

namespace AOV
{
    public class BdWaterSource : NationItem
    {
        private readonly Point _clicked;
        public BdWaterSource(Point clicked)
        {
            _clicked = clicked;
            Point p2 = new Point(_clicked.X + 5, _clicked.Y - 2);
            Point p3 = new Point(_clicked.X + 6, _clicked.Y);
            Point p4 = new Point(_clicked.X + 12, _clicked.Y - 5);
            Point p5 = new Point(_clicked.X + 19, _clicked.Y);
            Point p6 = new Point(_clicked.X + 17, _clicked.Y + 9);
            Point p7 = new Point(_clicked.X + 7, _clicked.Y + 5);
            Point p8 = new Point(_clicked.X, _clicked.Y + 11);
            Point p9 = new Point(_clicked.X - 5, _clicked.Y + 7);

            villageItemShape = new BdWaterSourceShape(_clicked, p2, p3, p4, p5, p6, p7, p8, p9);
        }
        public override Point GetPoint()
        {
            return _clicked;
        }
    }
}
