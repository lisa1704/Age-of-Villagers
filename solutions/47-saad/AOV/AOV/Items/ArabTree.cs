using System.Drawing;

namespace AOV
{
    public class ArabTree : NationItem
    {
        private readonly Point _clicked;
        public ArabTree(Point clicked)
        {
            _clicked = clicked;            
           
            Point topCenter = new Point(_clicked.X + 1, _clicked.Y);
            Point topRightCorner = new Point(_clicked.X + 2, _clicked.Y);
            Point bottomRightCorner = new Point(_clicked.X + 2, _clicked.Y + 12);
            Point x1 = new Point(_clicked.X - 7, _clicked.Y - 6);
            Point x2 = new Point(_clicked.X - 3, _clicked.Y - 10);
            Point x3 = new Point(topCenter.X, _clicked.Y - 12);
            Point x4 = new Point(topRightCorner.X + 3, _clicked.Y - 10);
            Point x5 = new Point(topRightCorner.X + 7, _clicked.Y - 6);

            villageItemShape = new ArabTreeShape(_clicked, x1, x2, x3, x4, x5, topCenter, topRightCorner, bottomRightCorner);                       
        }
        public override Point GetPoint()
        {
            return _clicked;
        }
    }
}
