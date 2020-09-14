using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class EgyptTree:CompositeShape
    {
        public EgyptTree(Point pt)
        {
            Point p1 = new Point(pt.X + 25, pt.Y - 50);
            Point p2 = new Point(pt.X - 26, pt.Y - 45);
            Point p3 = new Point(pt.X + 16, pt.Y - 30);
            Point p4 = new Point(pt.X + 39, pt.Y - 45);
            Point p5 = new Point(pt.X + 10, pt.Y - 48);
            Point p6 = new Point(pt.X - 18, pt.Y - 32);
            Point p7 = new Point(pt.X - 10, pt.Y - 50);
            Point p8 = new Point(pt.X - 35, pt.Y - 41);

            AddComponent(new Line(pt, p1));
            AddComponent(new Line(pt, p2));
            AddComponent(new Line(p3, p4));
            AddComponent(new Line(p3, p5));
            AddComponent(new Line(p6, p7));
            AddComponent(new Line(p6, p8));
        }
    }
}
