using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabHouseShape : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;
        private readonly float height, width;

        public ArabHouseShape(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            height = _bottomright.Y - _topleft.Y;
            width = _bottomright.X - _topleft.X;
            AddComponent(new MyTriangle(new Point((int)(_topleft.X + width * 0.4), (int)(_topleft.Y + height * 0.3)), new Point(_topleft.X, _bottomright.Y), new Point((int)(_topleft.X + width * 0.75), _bottomright.Y)));
            AddComponent(new Quadrilateral(new Point((int)(_topleft.X + width * 0.4), (int)(_topleft.Y + height * 0.3)), new Point((int)(_topleft.X + width * 0.75), _bottomright.Y), new Point(_bottomright.X, (int)(_topleft.Y + height * 0.7)), new Point((int)(_topleft.X + width * 0.66), _topleft.Y)));
        }

    }

}
