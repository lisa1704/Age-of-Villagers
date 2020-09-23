using System.Drawing;

namespace AOV
{
    public class InuitHouseShape : CompoundShape
    {
        public InuitHouseShape(Point clicked, Point x2, Point x3, Point x4)
        {
            AddShape(new DrawLine(x3, x4));
            AddShape(new DrawArc(clicked.X, clicked.Y, 16, 30, 0, -180));
            AddShape(new DrawArc(clicked.X + 6, x2.Y + 10, 4, 10, 0, -180));

            //Check
            //AddShape(new Rectangle(clicked, x3)); //Uncomment to check the height and width
        }
    }
}
