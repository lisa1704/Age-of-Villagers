using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiHouse : CompositeShape
    {
        public BangladeshiHouse(Point point)
        {
            Point top = point;
            Point baseTopLeft = new Point(top.X - 8, top.Y + 8);
            Point baseBottomRight = new Point(top.X + 8, top.Y + 16);

            AddComponent(new VShape(baseTopLeft, top, new Point(baseBottomRight.X, baseTopLeft.Y) ));
            AddComponent(new Rectangle(baseTopLeft, baseBottomRight));
        }
    }
}
