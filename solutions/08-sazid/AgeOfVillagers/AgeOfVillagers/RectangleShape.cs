using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class RectangleShape : AdvancedShape
    {
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4;

        public RectangleShape(Point p1, Point p3)
        {
            this.p2 = new Point(p3.X, p1.Y);
            this.p4 = new Point(p1.X, p3.Y);

            addShape(new LineShape(p1, p4));
            addShape(new LineShape(p1, p2));
            addShape(new LineShape(p4, p3));
            addShape(new LineShape(p3, p2));
        }
    }
}
