using System.Drawing;

namespace AOV
{
    class Ellipse : CompoundShape
    {
        readonly float height;
        readonly float width;

        public Ellipse(Point x1,Point x2)
        {
            height = x2.X - x1.X;
            width = x2.Y - x1.Y;
            addShape(new DrawArc(x1.X, x1.Y, height, width, 0, 360));
        }
    }
}
