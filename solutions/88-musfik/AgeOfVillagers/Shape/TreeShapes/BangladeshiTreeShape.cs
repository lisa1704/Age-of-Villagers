using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiTreeShape : CompositeShape
    {
        public BangladeshiTreeShape(Point point)
        {  
            Point TopLeft = new Point(point.X - 1, point.Y + 4);
            Point BottomRight = new Point(point.X + 1, point.Y + 16);
            Point Circle_topLeft = new Point(point.X - 8, point.Y - 8);
            Point Circle_bottomRight = new Point(point.X + 8, point.Y + 8);

            AddComponent(new Arc(Circle_topLeft, Circle_bottomRight, 0, 360));
            AddComponent(new Rectangle(TopLeft, BottomRight));
        }
    }
}
