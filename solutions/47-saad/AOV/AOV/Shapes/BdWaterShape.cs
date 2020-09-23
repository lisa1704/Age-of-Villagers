using System.Drawing;

namespace AOV
{
    public class BdWaterSourceShape : CompoundShape
    {
        public BdWaterSourceShape(Point clicked, Point x2, Point x3, Point x4, Point x5, Point x6, Point x7, Point x8, Point x9)
        {
            AddShape(new DrawLine(clicked, x2));
            AddShape(new DrawLine(x2, x3));
            AddShape(new DrawLine(x3, x4));
            AddShape(new DrawLine(x4, x5));
            AddShape(new DrawLine(x5, x6));
            AddShape(new DrawLine(x6, x7));
            AddShape(new DrawLine(x7, x8));
            AddShape(new DrawLine(x8, x9));
            AddShape(new DrawLine(x9, clicked));
        }       
    }
}
