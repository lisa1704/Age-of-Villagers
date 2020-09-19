using System.Drawing;

namespace AgeOfVillagers.Components
{
    public class Rectangle:CompositeShape
    {
        public Point topLeft, topRight, bottomLeft, bottomRight;

        public Rectangle(Point topLeft, Point topRight, Point bottomLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;

            AddComponent(new Line(topLeft.X, topLeft.Y, topRight.X, topRight.Y));
            AddComponent(new Line(topLeft.X, topLeft.Y, bottomLeft.X, bottomLeft.Y));
            AddComponent(new Line(bottomLeft.X, bottomLeft.Y, bottomRight.X, bottomRight.Y));
            AddComponent(new Line(bottomRight.X, bottomRight.Y, topRight.X, topRight.Y));
        }
    }
}
