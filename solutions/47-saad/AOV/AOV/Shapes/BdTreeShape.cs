using System.Drawing;

namespace AOV
{
    public class BdTreeShape : CompoundShape
    {
        public BdTreeShape(Point clicked, Point top, Point topLeftCorner, Point bottomRightCorner)
        {
            addShape(new Ellipse(clicked, top));
            addShape(new Rectangle(topLeftCorner, bottomRightCorner));
        }
    }
}
