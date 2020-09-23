using System.Drawing;

namespace AOV
{
    public class BdWaterSourceShape : CompoundShape
    {
        public BdWaterSourceShape(Point clicked, Point p2, Point p3, Point p4, Point p5, Point p6, Point p7, Point p8, Point p9)
        {
            addShape(new DrawLine(clicked, p2));
            addShape(new DrawLine(p2, p3));
            addShape(new DrawLine(p3, p4));
            addShape(new DrawLine(p4, p5));
            addShape(new DrawLine(p5, p6));
            addShape(new DrawLine(p6, p7));
            addShape(new DrawLine(p7, p8));
            addShape(new DrawLine(p8, p9));
            addShape(new DrawLine(p9, clicked));
        }       
    }
}
