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

}
