using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiTreeShape : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;
        private readonly float ellipseheight, height, width;

        public BangladeshiTreeShape(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            height = _bottomright.Y - _topleft.Y;
            width = _bottomright.X - _topleft.X;
            ellipseheight = (float)(height * 0.75);
            AddComponent(new Ellipse(_topleft, new Point(_bottomright.X, (int)(_topleft.Y+ellipseheight))));
            AddComponent(new MyRectangle(new Point((int)(_topleft.X + width/2 -1), (int)(_topleft.Y + height/2)), new Point((int)(_topleft.X + width / 2 + 1), _bottomright.Y)));
        }

    }

}
