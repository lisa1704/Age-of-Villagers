using System.Drawing;

namespace AOV
{
    public class ArabHouse : NationItem
    {
        private readonly Point _clicked;
        public ArabHouse(Point clicked)
        {
            _clicked = clicked;
            Point x1 = new Point(_clicked.X - 4, _clicked.Y + 10);
            Point x2 = new Point(_clicked.X + 4, _clicked.Y + 10);
            Point x3 = new Point(x2.X + 4, _clicked.Y - 6);
            Point x4 = new Point(x3.X + 4, x2.Y - 6);

            Point topLeftCorner = new Point(_clicked.X - 4, clicked.Y - 6);
            Point bottomRightCorner = new Point(clicked.X + 12, clicked.Y + 10);

            villageItemShape = new ArabHouseShape(_clicked, x1, x2, x3, x4, topLeftCorner, bottomRightCorner);

           
            //Check
            //addShape(new Rectangle(topLeftCorner, bottomRightCorner)); //Uncomment to check the height and width
        }
        public override Point GetPoint()
        {
            return _clicked;
        }
    }
}
