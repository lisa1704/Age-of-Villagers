using System.Drawing;

namespace AgeOfVillagers
{
    public class MyTriangle : Shape
    {
        private readonly Point _top;
        private readonly Point _bottomleft;
        private readonly Point _bottomright;

        public MyTriangle(Point top, Point bottomleft, Point bottomright)
        {
            _top = top;
            _bottomright = bottomright;
            _bottomleft = bottomleft;
            AddComponent(new MyLine(_top, _bottomleft));
            AddComponent(new MyLine(_top, _bottomright));
            AddComponent(new MyLine(_bottomleft, _bottomright));
        }

    }

}
