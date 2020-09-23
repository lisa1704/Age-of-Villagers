using System.Drawing;

namespace AOV
{
    public class BdWaterSourceShape : CompoundShape
    {
        public BdWaterSourceShape(Point clicked, Point p2, Point p3, Point p4, Point p5, Point p6, Point p7, Point p8, Point p9)
        {
            AddShape(new DrawLine(clicked, p2));
            AddShape(new DrawLine(p2, p3));
            AddShape(new DrawLine(p3, p4));
            AddShape(new DrawLine(p4, p5));
            AddShape(new DrawLine(p5, p6));
            AddShape(new DrawLine(p6, p7));
            AddShape(new DrawLine(p7, p8));
            AddShape(new DrawLine(p8, p9));
            AddShape(new DrawLine(p9, clicked));
        }       
    }
}
