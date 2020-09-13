using System.Drawing;

namespace AgeOfVillagers
{
    public class Quadrilateral : Shape
    {
        private readonly Point _point1;
        private readonly Point _point2;
        private readonly Point _point3;
        private readonly Point _point4;

        public Quadrilateral(Point point1, Point point2, Point point3, Point point4)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _point4 = point4;
            AddComponent(new MyLine(_point1, _point2));
            AddComponent(new MyLine(_point2, _point3));
            AddComponent(new MyLine(_point3, _point4));
            AddComponent(new MyLine(_point4, _point1));
        }
    }

}
