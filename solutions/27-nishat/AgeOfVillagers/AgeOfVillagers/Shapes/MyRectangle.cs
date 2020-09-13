using System.Drawing;

namespace AgeOfVillagers
{
    public class MyRectangle : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;

        public MyRectangle(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            AddComponent(new MyLine(_topleft, new Point(_bottomright.X, _topleft.Y)));
            AddComponent(new MyLine(_topleft, new Point(_topleft.X, _bottomright.Y)));
            AddComponent(new MyLine(new Point(_bottomright.X, _topleft.Y), _bottomright));
            AddComponent(new MyLine(new Point(_topleft.X, _bottomright.Y), _bottomright));
        }


    }

}
