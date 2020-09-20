using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class ArabBedouinTree : AbstractShape
    {
        public ArabBedouinTree(Point Initialpoint)
        {
            Point TopRight = new Point(Initialpoint.X + 22, Initialpoint.Y + 20);
            Point RightTopLeftPoint = new Point(Initialpoint.X + 20, Initialpoint.Y + 20);

            addShape(new Rectangle(RightTopLeftPoint, new Point(Initialpoint.X + 25, Initialpoint.Y + 80)));
            addShape(new Line(RightTopLeftPoint, new Point(Initialpoint.X, Initialpoint.Y - 15)));
            addShape(new Line(TopRight, new Point(Initialpoint.X + 40, Initialpoint.Y - 15)));
            addShape(new Line(TopRight, new Point(Initialpoint.X + 40, Initialpoint.Y + 15)));
            addShape(new Line(TopRight, new Point(Initialpoint.X + 40, Initialpoint.Y - 50)));
            addShape(new Line(TopRight, new Point(Initialpoint.X + 40, Initialpoint.Y)));
        }
    }
}
