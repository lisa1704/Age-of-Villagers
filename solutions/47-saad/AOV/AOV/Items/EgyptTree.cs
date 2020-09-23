using System.Drawing;

namespace AOV
{
    public class EgyptTree : NationItem
    {
        private readonly Point _clicked;
        public EgyptTree(Point clicked)
        {
            _clicked = clicked;
            Point x2 = new Point(_clicked.X - 4, _clicked.Y - 16);
            Point x3 = new Point(_clicked.X-8 , _clicked.Y - 20);
            Point x4 = new Point(_clicked.X - 5, _clicked.Y - 22);
            Point x5 = new Point(_clicked.X - 1, _clicked.Y - 24);
            Point x6 = new Point(_clicked.X + 4, _clicked.Y - 12);
            Point x7 = new Point(_clicked.X + 2, _clicked.Y - 24);
            Point x8 = new Point(_clicked.X + 8, _clicked.Y - 24);
            Point x9 = new Point(_clicked.X + 8, _clicked.Y - 16);

            villageItemShape = new EgyptTreeShape(_clicked, x2, x3, x4, x5, x6, x7, x8, x9);            
        }
        public override Point GetPoint()
        {
            return _clicked;
        }
    }
}
