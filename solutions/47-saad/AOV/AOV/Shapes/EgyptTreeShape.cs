using System.Drawing;

namespace AOV
{
    public class EgyptTreeShape : CompoundShape
    {
        public EgyptTreeShape(Point clicked, Point x2, Point x3, Point x4, Point x5, Point x6, Point x7, Point x8, Point x9)
        {
            AddShape(new DrawLine(clicked, x4));
            AddShape(new DrawLine(x2, x3));
            AddShape(new DrawLine(x2, x5));
            AddShape(new DrawLine(clicked, x8));
            AddShape(new DrawLine(x6, x7));
            AddShape(new DrawLine(x6, x9));
        }
    }
}
