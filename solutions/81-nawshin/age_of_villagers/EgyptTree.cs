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

            AddComponent(new Line(pt, rm));
            AddComponent(new Line(rm, rt));
            AddComponent(new Line(rm, rr));
            AddComponent(new Line(rm, rl));
            AddComponent(new Line(pt, lm));
            AddComponent(new Line(lm, lt));
            AddComponent(new Line(lm, lr));
            AddComponent(new Line(lm, ll));

        }
    }
}
