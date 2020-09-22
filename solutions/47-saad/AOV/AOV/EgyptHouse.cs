using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class EgyptHouse : CompoundShape
    {
        public EgyptHouse(Point clicked)
        {
            Point x1 = new Point(clicked.X - 7, clicked.Y + 13);
            Point x2 = new Point(clicked.X + 4, clicked.Y + 16);
            Point x3 = new Point(x1.X + 16, clicked.Y + 11);

            Point topLeftCorner = new Point(clicked.X - 7, clicked.Y);
            Point bottomRightCorner = new Point(clicked.X + 9, clicked.Y + 16);

            addShape(new Triangle(clicked, x1, x2));
            addShape(new Triangle(clicked, x2, x3));
            //Check
            //addShape(new Rectangle(topLeftCorner, bottomRightCorner)); //Uncomment to check the height and width
        }
    }
}
