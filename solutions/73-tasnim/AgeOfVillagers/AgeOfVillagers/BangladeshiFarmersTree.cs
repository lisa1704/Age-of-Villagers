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
            addShape(new Circle(Initialpoint, new Point(Initialpoint.X + 16, Initialpoint.Y + 16)));
            addShape(new Rectangle(new Point(Initialpoint.X + 7, Initialpoint.Y + 8), new Point(Initialpoint.X + 9, Initialpoint.Y + 24)));
        }
    }
}
