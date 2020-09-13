using System.Drawing;

namespace AgeOfVillagers
{
    internal class BangladeshiPondShape : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;
        private readonly float height, width;

        public BangladeshiPondShape(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            height = _bottomright.Y - _topleft.Y;
            width = _bottomright.X - _topleft.X;
            AddComponent(new VShape(new Point(_topleft.X, (int)(_topleft.Y + height * 0.7)), new Point((int)(_topleft.X + width * 0.24), (int)(_topleft.Y + height * 0.13)), new Point((int)(_topleft.X + width * 0.48), (int)(_topleft.Y + height * 0.07))));
            AddComponent(new VShape(new Point((int)(_topleft.X + width * 0.48), (int)(_topleft.Y + height * 0.3)), new Point((int)(_topleft.X + width * 0.71), _topleft.Y), new Point(_bottomright.X, (int)(_topleft.Y + height * 0.3))));
            AddComponent(new VShape(new Point(_topleft.X, (int)(_topleft.Y + height * 0.7)), new Point((int)(_topleft.X + width * 0.3), _bottomright.Y), new Point((int)(_topleft.X + width * 0.57), (int)(_topleft.Y + height * 0.8))));
            AddComponent(new VShape(new Point((int)(_topleft.X + width * 0.57), (int)(_topleft.Y + height * 0.8)), new Point((int)(_topleft.X + width * 0.86), (int)(_topleft.Y + height * 0.93)), new Point(_bottomright.X, (int)(_topleft.Y + height * 0.3))));
            AddComponent(new MyLine(new Point((int)(_topleft.X + width * 0.48), (int)(_topleft.Y + height * 0.07)), new Point((int)(_topleft.X + width * 0.48), (int)(_topleft.Y + height * 0.3))));
        }
    }
}