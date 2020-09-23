using System.Drawing;

namespace AOV
{
    public class EgyptWaterShape : CompoundShape
    {
        public EgyptWaterShape(Point clicked, Point p)
        {
            addShape(new Ellipse(clicked, p));
        }
    }
}
