using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BangladeshiFarmersWater : AbstractShape
    {
        public BangladeshiFarmersWater(Point Initialpoint)
        {
            Point p1 = new Point(Initialpoint.X - 20, Initialpoint.Y + 40);
            Point p2 = new Point(Initialpoint.X, Initialpoint.Y + 60);
            Point p3 = new Point(Initialpoint.X + 20, Initialpoint.Y + 40);
            Point p4 = new Point(Initialpoint.X + 40, Initialpoint.Y + 60);
            Point p5 = new Point(Initialpoint.X + 60, Initialpoint.Y + 20);
            Point p6 = new Point(Initialpoint.X + 40, Initialpoint.Y);
            Point p7 = new Point(Initialpoint.X + 20, Initialpoint.Y + 20);
            Point p8 = new Point(Initialpoint.X + 20, Initialpoint.Y);

            addShape(new Line(Initialpoint, p1));
            addShape(new Line(p1, p2));
            addShape(new Line(p2, p3));
            addShape(new Line(p3, p4));
            addShape(new Line(p4, p5));
            addShape(new Line(p5, p6));
            addShape(new Line(p6, p7));
            addShape(new Line(p7, p8));
            addShape(new Line(p8, Initialpoint));
        }
    }
}
