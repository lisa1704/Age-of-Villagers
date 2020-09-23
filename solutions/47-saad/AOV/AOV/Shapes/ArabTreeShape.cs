using System.Drawing;

namespace AOV
{
    public class ArabTreeShape : CompoundShape
    {
        public ArabTreeShape(Point clicked, Point x1, Point x2, Point x3, Point x4, Point x5, Point topCenter, Point topRightCorner, Point bottomRightCorner)
        {
            AddShape(new Rectangle(clicked, bottomRightCorner));
            AddShape(new DrawLine(topCenter, x3));
            AddShape(new DrawLine(clicked, x1));
            AddShape(new DrawLine(clicked, x2));
            AddShape(new DrawLine(topRightCorner, x4));
            AddShape(new DrawLine(topRightCorner, x5));
        }
    }
}
