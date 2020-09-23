using System.Drawing;

namespace AOV
{
    class Triangle : CompoundShape
    {
        public Triangle(Point x1, Point x2, Point x3)
        {
            AddShape(new DrawLine(x1, x2));
            AddShape(new DrawLine(x2, x3));
            AddShape(new DrawLine(x3, x1));
        }
    }
}
