using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class BDWatersource:CompositeShape
    {
        public BDWatersource(Point pt)
        {
            Point p1 = new Point(pt.X - 25, pt.Y + 50);
            Point p2 = new Point(pt.X, pt.Y + 75);
            Point p3 = new Point(pt.X +25, pt.Y + 50);
            Point p4 = new Point(pt.X +50, pt.Y + 75);
            Point p5 = new Point(pt.X +75, pt.Y + 25);
            Point p6 = new Point(pt.X +50, pt.Y);
            Point p7 = new Point(pt.X+25, pt.Y + 25);
            Point p8 = new Point(pt.X + 25, pt.Y);

            AddComponent(new Line(pt,p1));
            AddComponent(new Line(p1,p2));
            AddComponent(new Line(p2,p3));
            AddComponent(new Line(p3,p4));
            AddComponent(new Line(p4,p5));
            AddComponent(new Line(p5,p6));
            AddComponent(new Line(p6,p7));
            AddComponent(new Line(p7,p8));
            AddComponent(new Line(p8,pt));

        }
    }
}
