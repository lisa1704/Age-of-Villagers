using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class BdTree : CompoundShape
    {
        public BdTree(Point clicked)
        {
            Point topLeftCorner = new Point(clicked.X + 45, clicked.Y + 70);
            Point bottomRightCorner = new Point(clicked.X + 51, clicked.Y + 130);
            Point top = new Point(clicked.X + 85, clicked.Y + 100);

            addShape(new Rectangle(topLeftCorner, bottomRightCorner));
            addShape(new Ellipse(clicked, top));
        }
    }
}
