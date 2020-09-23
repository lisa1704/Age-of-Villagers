using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AoV.Shapes
{
    class BangladeshiHouse : ComposeShape
    {

        private Point p1, p2, p3;

        public BangladeshiHouse(Point p1, Point p2, Point p3)
        {

            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            AddShape(new Triangle(p1, p2, new Point(p2.X, p3.Y)));
            AddShape(new Rectangle(p2, p3));
        }

    }
}
