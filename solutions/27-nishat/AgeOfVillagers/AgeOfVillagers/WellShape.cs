using System.Drawing;

namespace AgeOfVillagers
{
    public class WellShape : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;

        public WellShape(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            AddComponent(new Ellipse(_topleft, _bottomright));
        }
    }

    public class EgyptianHouseShape : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;
        private readonly float height, width;

        public EgyptianHouseShape(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            height = _bottomright.Y - _topleft.Y;
            width = _bottomright.X - _topleft.X;

            AddComponent(new MyTriangle(new Point((int)(_topleft.X + width * 0.45), _topleft.Y),new Point(_topleft.X, (int)(_topleft.Y + height * 0.8)), new Point((int)(_topleft.X + width * 0.63), _bottomright.Y)));
            AddComponent(new MyTriangle(new Point(_bottomright.X, (int)(_topleft.Y + height * 0.6)), new Point((int)(_topleft.X + width * 0.45), _topleft.Y), new Point((int)(_topleft.X + width * 0.63), _bottomright.Y)));
        }
    }

    public class EgyptianTreeShape : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;
        private readonly float height, width;

        public EgyptianTreeShape(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            height = _bottomright.Y - _topleft.Y;
            width = _bottomright.X - _topleft.X;

            AddComponent(new VShape(new Point((int)(_topleft.X + width * 0.17), (int)(_topleft.Y + height * 0.1)), new Point((int)(_topleft.X + width * 0.5), _bottomright.Y), new Point((int)(_topleft.X + width * 0.75), (int)(_topleft.Y + height * 0.05))));
            AddComponent(new VShape(new Point(_topleft.X, (int)(_topleft.Y + height * 0.2)), new Point((int)(_topleft.X + width * 0.28), (int)(_topleft.Y + height * 0.4)), new Point((int)(_topleft.X + width * 0.4), _topleft.Y)));
            AddComponent(new VShape(new Point((int)(_topleft.X + width * 0.62), (int)(_topleft.Y + height * 0.05)), new Point((int)(_topleft.X + width * 0.66), (int)(_topleft.Y + height * 0.4)), new Point(_bottomright.X, (int)(_topleft.Y + height * 0.17))));
        }
    }

}
