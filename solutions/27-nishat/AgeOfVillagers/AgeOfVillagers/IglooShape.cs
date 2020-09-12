using System.Drawing;

namespace AgeOfVillagers
{
    public class IglooShape : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;
        private readonly float height, width;

        public IglooShape(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            height = _bottomright.Y - _topleft.Y;
            width = _bottomright.X - _topleft.X;
            AddComponent(new MyLine(new Point(_topleft.X, _bottomright.Y), _bottomright));
            AddComponent(new HalfCircle(_topleft, new Point(_bottomright.X, (int)(_bottomright.Y))));
            AddComponent(new HalfCircle(new Point((int)(_topleft.X + width * 0.3125), (int)(_topleft.Y + height * 0.8125)), new Point((int)(_topleft.X + width * 0.6875), (int)(_bottomright.Y))));
        }
    }

}
