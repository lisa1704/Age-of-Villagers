using System.Drawing;

namespace AOV
{
    class ArabHouseShape : CompoundShape
    {
        public ArabHouseShape(Point clicked, Point x1, Point x2, Point x3, Point x4, Point topLeftCorner, Point bottomRightCorner)
        {
            AddShape(new Triangle(x1, x2, clicked));
            AddShape(new DrawLine(x3, clicked));
            AddShape(new DrawLine(x2, x4));
            AddShape(new DrawLine(x3, x4));
        }
    }
}
