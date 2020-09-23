using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AoV.Shapes
{
    class EgyptianWell : ComposeShape
    {
        public EgyptianWell(Point clickPoint)
        {
            Point p1 = new Point(clickPoint.X + 50, clickPoint.Y + 50);
            AddShape(new Ellipse(clickPoint, p1));
        }
    }
}
