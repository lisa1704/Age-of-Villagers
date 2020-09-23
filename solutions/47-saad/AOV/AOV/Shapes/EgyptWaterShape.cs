using System.Drawing;

namespace AOV
{
    public class EgyptWaterShape : CompoundShape
    {
        public EgyptWaterShape(Point clicked, Point p)
        {
            AddShape(new Ellipse(clicked, p));
        }
    }
}
