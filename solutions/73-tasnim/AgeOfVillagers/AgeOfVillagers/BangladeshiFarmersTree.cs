using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BangladeshiFarmersTree : AbstractShape
    {
        public BangladeshiFarmersTree(Point Initialpoint)
        {
            Point topLeftPoint = new Point(Initialpoint.X + 40, Initialpoint.Y + 60);
            Point bottomRightPoint = new Point(Initialpoint.X + 50, Initialpoint.Y + 180);
            Point topPoint = new Point(Initialpoint.X + 100, Initialpoint.Y + 90);

            addShape(new Rectangle(topLeftPoint, bottomRightPoint));
            addShape(new Circle(Initialpoint, topPoint));
        }
    }
}
