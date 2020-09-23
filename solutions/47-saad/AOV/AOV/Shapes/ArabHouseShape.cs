using System.Drawing;

namespace AOV
{
    class ArabHouseShape : CompoundShape
    {
        public ArabHouseShape(Point clicked, Point x1, Point x2, Point x3, Point x4, Point topLeftCorner, Point bottomRightCorner)
        {
            addShape(new Triangle(x1, x2, clicked));
            addShape(new DrawLine(x3, clicked));
            addShape(new DrawLine(x2, x4));
            addShape(new DrawLine(x3, x4));
        }
    }
}
