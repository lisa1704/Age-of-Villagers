using System.Drawing;

namespace AOV.Shapes
{
    public class ArabTreeShape : CompoundShape
    {
        public ArabTreeShape(Point clicked, Point x1, Point x2, Point x3, Point x4, Point x5, Point topCenter, Point topRightCorner, Point bottomRightCorner)
        {
            addShape(new Rectangle(clicked, bottomRightCorner));
            addShape(new DrawLine(topCenter, x3));
            addShape(new DrawLine(clicked, x1));
            addShape(new DrawLine(clicked, x2));
            addShape(new DrawLine(topRightCorner, x4));
            addShape(new DrawLine(topRightCorner, x5));
        }
    }
}
