using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InuitHunterHouse : CompositeShapes
    {

        private Point point;
        
        public InuitHunterHouse(Point point)
        {
            this.point = point;
            Point sarc = new Point(point.X + 8, point.Y + 8);
            Point p1 = new Point(point.X, point.Y + 12);
            Point p2 = new Point(point.X + 24, point.Y + 12);

            addshapes(new Arc(sarc, 8, 8, 0, -180));
            addshapes(new Arc(point, 24, 24, 0, -180));
            addshapes(new Line(p1, p2));
        }

    }
}
