using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EllipseShape : AdvancedShape
    {
        private Point p1;
        private Point p2;

        public EllipseShape(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            addShape(new ArcShape(p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y, 0, 360));
        }
    }
}
