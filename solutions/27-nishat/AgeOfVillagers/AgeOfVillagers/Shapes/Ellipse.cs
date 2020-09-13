using System.Drawing;

namespace AgeOfVillagers
{
    public class Ellipse : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;

        public Ellipse(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            AddComponent(new MyArc(_topleft.X,_topleft.Y, _bottomright.X-_topleft.X , _bottomright.Y-_topleft.Y ,0,360));
        }
    }
}
