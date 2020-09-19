using AgeOfVillagers.Data_Objects;
using System.Drawing;
using AgeOfVillagers.Components;

namespace AgeOfVillagers.Tree
{
    public class EgyptianTree : CompositeShape
    {
     
        public EgyptianTree(Point p, ElementSize sz)
        {
            Point p1 = new Point (p.X + sz.width / 3, p.Y - (sz.height - 4));
            Point p2 = new Point(p.X - sz.width / 3, p.Y - (sz.height - 4));
            Point p3 = new Point(p.X - sz.width / 2, p.Y - sz.height);
            Point p4 = new Point(p.X + sz.width / 2, p.Y - sz.height);

            AddComponent(new Line(p.X, p.Y, p1.X, p1.Y));
            AddComponent(new Line(p.X, p.Y, p2.X, p2.Y));
            AddComponent(new Line(p1.X, p1.Y, p4.X, p4.Y));
            AddComponent(new Line(p2.X, p2.Y, p3.X, p3.Y));
        }
    }
}
