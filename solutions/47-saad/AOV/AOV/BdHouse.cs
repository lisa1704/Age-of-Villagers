using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class BdHouse : CompoundShape
    {
        public BdHouse(Point clicked)
        {
            int baseLine = clicked.Y + 8;

            Point x1 = new Point(clicked.X - 8, baseLine);
            Point x2 = new Point(clicked.X + 8, baseLine);
            Point topLeftCorner = new Point(clicked.X - 8, clicked.Y);
            Point bottomRightCorner = new Point(clicked.X + 8, clicked.Y + 16);

            addShape(new Rectangle(x1, bottomRightCorner));
            addShape(new Triangle(clicked, x1, x2));
            //Check
            //addShape(new Rectangle(topLeftCorner, bottomRightCorner)); //Uncomment to check the height and width
        }
    }
}
