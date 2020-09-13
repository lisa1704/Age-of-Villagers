using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiHouseShape : Shape
    {
        private readonly Point _top;
        private readonly Point _middleleft;
        private readonly Point _bottomright;

        public BangladeshiHouseShape(Point top, Point middleleft, Point bottomright)
        {
            _top = top;
            _bottomright = bottomright;
            _middleleft = middleleft;
            AddComponent(new MyTriangle(_top, _middleleft, new Point(_bottomright.X, _middleleft.Y)));
            AddComponent(new MyRectangle(_middleleft, _bottomright));
        }
    }
}
