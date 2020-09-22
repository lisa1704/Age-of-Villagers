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
            Point top = new Point(clicked.X + 16, clicked.Y + 18);
            Point topLeftCorner = new Point(clicked.X+7, clicked.Y+14);
            Point bottomRightCorner = new Point(clicked.X + 9, clicked.Y + 24);
            
            addShape(new Ellipse(clicked, top));
            addShape(new Rectangle(topLeftCorner, bottomRightCorner));
        }
    }
}
