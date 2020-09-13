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

    public class ArabTreeShape : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;
        private readonly float height, width;

        public ArabTreeShape(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            height = _bottomright.Y - _topleft.Y;
            width = _bottomright.X - _topleft.X;
            AddComponent(new MyLine(new Point((int)(_topleft.X + width / 2), _topleft.Y), new Point((int)(_topleft.X + width / 2), (int)(_topleft.Y + height / 2))));
            AddComponent(new VShape(new Point(_topleft.X, (int)(_topleft.Y + height * 0.38)), new Point((int)(_topleft.X + width / 2), (int)(_topleft.Y + height / 2)), new Point((int)(_topleft.X + width * 0.13), (int)(_topleft.Y + height * 0.17))));
            AddComponent(new VShape(new Point(_bottomright.X, (int)(_topleft.Y + height * 0.38)), new Point((int)(_topleft.X + width / 2), (int)(_topleft.Y + height / 2)), new Point((int)(_topleft.X + width * 0.87), (int)(_topleft.Y + height * 0.17))));
            AddComponent(new MyRectangle(new Point((int)(_topleft.X + width / 2 - 1), (int)(_topleft.Y + height / 2)), new Point((int)(_topleft.X + width / 2 + 1), _bottomright.Y)));

        }

    }

}
