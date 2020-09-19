using System.Drawing;

namespace AgeOfVillagers.Components
{
    public class Triangle : CompositeShape
    {
        public Point top, left, right;

        public Triangle(Point top, Point left, Point right)
        {
            this.top = top;
            this.left = left;
            this.right = right;

            AddComponent(new Line(top.X, top.Y, left.X, left.Y));
            AddComponent(new Line(left.X, left.Y, right.X, right.Y));
            AddComponent(new Line(right.X, right.Y, top.X, top.Y));
        }
    }
}
