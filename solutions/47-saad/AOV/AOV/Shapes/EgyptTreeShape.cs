using System.Drawing;

namespace AOV
{
    public class EgyptTreeShape : CompoundShape
    {
        public EgyptTreeShape(Point clicked, Point x2, Point x3, Point x4, Point x5, Point x6, Point x7, Point x8, Point x9)
        {
            addShape(new DrawLine(clicked, x4));
            addShape(new DrawLine(x2, x3));
            addShape(new DrawLine(x2, x5));
            addShape(new DrawLine(clicked, x8));
            addShape(new DrawLine(x6, x7));
            addShape(new DrawLine(x6, x9));
        }
    }
}
