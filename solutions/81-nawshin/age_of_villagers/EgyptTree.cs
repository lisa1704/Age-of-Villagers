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
            Point rt= new Point(pt.X + 6, pt.Y - 23);
            Point rm = new Point(pt.X + 2, pt.Y - 9);
            Point rr = new Point(pt.X + 8, pt.Y - 15);
            Point rl = new Point(pt.X + 1, pt.Y - 22);
            Point lt = new Point(pt.X - 6, pt.Y - 24);
            Point lm = new Point(pt.X - 3, pt.Y - 11);
            Point lr = new Point(pt.X - 2, pt.Y - 22);
            Point ll = new Point(pt.X - 8, pt.Y - 18);

            /*Point p1 = new Point(pt.X + 5, pt.Y - 23);
            Point p2 = new Point(pt.X - 7, pt.Y - 24);
            Point p3 = new Point(pt.X + 2, pt.Y - 9);
            Point p4 = new Point(pt.X + 8, pt.Y - 18);
            Point p5 = new Point(pt.X + 1, pt.Y - 22);
            Point p6 = new Point(pt.X - 4, pt.Y - 11);
            Point p7 = new Point(pt.X - 3, pt.Y - 12);
            Point p8 = new Point(pt.X - 8, pt.Y - 10);*/


            AddComponent(new Line(pt, rm));
            AddComponent(new Line(rm, rt));
            AddComponent(new Line(rm, rr));
            AddComponent(new Line(rm, rl));
            AddComponent(new Line(pt, lm));
            AddComponent(new Line(lm, lt));
            AddComponent(new Line(lm, lr));
            AddComponent(new Line(lm, ll));

            //AddComponent(new Line(pt, p1));
            //AddComponent(new Line(pt, p2));
            //AddComponent(new Line(p3, p4));
            //AddComponent(new Line(p3, p5));
            //AddComponent(new Line(p6, p7));
            //AddComponent(new Line(p6, p8));
        }
    }
}
