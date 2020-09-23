using System.Drawing;

namespace AOV
{
    public class BdTree : NationItem
    {
        private readonly Point _clicked;
        public BdTree(Point clicked)
        {
            _clicked = clicked;
            Point top = new Point(clicked.X + 16, clicked.Y + 18);
            Point topLeftCorner = new Point(clicked.X+7, clicked.Y+14);
            Point bottomRightCorner = new Point(clicked.X + 9, clicked.Y + 24);

            villageItemShape = new BdTreeShape(clicked, top, topLeftCorner, bottomRightCorner);            
        }
        public override Point GetPoint()
        {
            return _clicked;
        }
    }
}
