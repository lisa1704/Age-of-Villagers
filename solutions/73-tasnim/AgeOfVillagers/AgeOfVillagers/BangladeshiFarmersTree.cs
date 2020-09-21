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
            Point topLeftPoint = new Point(Initialpoint.X + 30, Initialpoint.Y + 30);
            Point bottomRightPoint = new Point(Initialpoint.X + 35, Initialpoint.Y + 80);
            Point topPoint = new Point(Initialpoint.X + 60, Initialpoint.Y + 60);

            addShape(new Rectangle(topLeftPoint, bottomRightPoint));
            addShape(new Circle(Initialpoint, topPoint));
        }
    }
}
