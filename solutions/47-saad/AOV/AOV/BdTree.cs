using System.Drawing;

namespace AOV
{
    public class BdTree : NationItem
    {
        private readonly Point _clicked;
        public BdTree(Point clicked)
        {
            _clicked = clicked;
            Point top = new Point(_clicked.X + 16, _clicked.Y + 18);
            Point topLeftCorner = new Point(_clicked.X+7, _clicked.Y+14);
            Point bottomRightCorner = new Point(_clicked.X + 9, _clicked.Y + 24);

            villageItemShape = new BdTreeShape(_clicked, top, topLeftCorner, bottomRightCorner);            
        }
        public override Point GetPoint()
        {
            return _clicked;
        }
    }
}
