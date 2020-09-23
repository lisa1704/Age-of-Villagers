using System.Drawing;

namespace AOV
{
    public class BdTreeShape : CompoundShape
    {
        public BdTreeShape(Point clicked, Point top, Point topLeftCorner, Point bottomRightCorner)
        {
            AddShape(new Ellipse(clicked, top));
            AddShape(new Rectangle(topLeftCorner, bottomRightCorner));
        }
    }
}
