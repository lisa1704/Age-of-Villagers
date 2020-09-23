using System.Drawing;

namespace AOV
{
    class EgyptWater : CompoundShape
    {
        public EgyptWater(Point clicked)
        {
            Point p = new Point(clicked.X + 12, clicked.Y + 12);
            addShape(new Ellipse(clicked, p));
        }
    }
}
