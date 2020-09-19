using AgeOfVillagers.Components;
using AgeOfVillagers.Data_Objects;
using System.Drawing;

namespace AgeOfVillagers.House
{
    public class InuitHouse : CompositeShape
    {
        public InuitHouse(Point p,ElementSize sz)
        {
            Point left = new Point(p.X, p.Y + sz.width / 2);
            Point right = new Point(p.X + sz.width, p.Y + sz.width / 2);

            AddComponent(new Line(left.X, left.Y, right.X, right.Y));
            AddComponent(new Arc(p.X, p.Y, sz.width, sz.height, 0, -180));
            AddComponent(new Arc(p.X + sz.height / 3, p.Y + sz.height / 2 - sz.height / 8, sz.height / 4, sz.height / 4, 0, -180));
        }
    }
}
