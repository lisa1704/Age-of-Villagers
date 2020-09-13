using System.Drawing;

namespace AgeOfVillagers
{
    public class VShape : Shape
    {
        private readonly Point _point1;
        private readonly Point _middlepoint;
        private readonly Point _point2;

        public VShape(Point point1, Point middlepoint, Point point2)
        {
            _point1 = point1;
            _middlepoint = middlepoint;
            _point2 = point2;
            AddComponent(new MyLine(_point1, _middlepoint));
            AddComponent(new MyLine(_middlepoint, _point2));
        }
    }

}
