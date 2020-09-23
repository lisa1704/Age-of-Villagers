using System.Drawing;

namespace AOV
{
    public class BdHouseShape : CompoundShape
    {       
        public BdHouseShape(Point clicked,Point x1, Point x2, Point topLeftCorner, Point bottomRightCorner)
        {
            AddShape(new Rectangle(x1, bottomRightCorner));
            AddShape(new Triangle(clicked, x1, x2));

            //Check
            //AddShape(new Rectangle(topLeftCorner, bottomRightCorner)); //Uncomment to check the height and width
        }
    }
}
