using System.Drawing;

namespace AgeOfVillagers90
{
    public class TAngle : CompositeShape
    {
        public TAngle(Point pt1,Point pt2,Point pt3)
        {
            AddComponent(new Line(pt1, pt2));
            AddComponent(new Line(pt2, pt3));
            AddComponent(new Line(pt3, pt1));
        }
    }
}
