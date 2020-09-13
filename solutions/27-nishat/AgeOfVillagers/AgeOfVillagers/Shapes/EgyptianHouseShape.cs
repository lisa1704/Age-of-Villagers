using System.Drawing;

namespace AgeOfVillagers
{
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

}
