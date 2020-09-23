using System.Drawing;

namespace AOV
{
    class EgyptHouseShape : CompoundShape
    {
        public EgyptHouseShape(Point clicked, Point x1, Point x2, Point x3, Point topLeftCorner, Point bottomRightCorner)
        {
            AddShape(new Triangle(clicked, x1, x2));
            AddShape(new Triangle(clicked, x2, x3));

            //Check
            //AddShape(new Rectangle(topLeftCorner, bottomRightCorner)); //Uncomment to check the height and width
        }
    }
}
