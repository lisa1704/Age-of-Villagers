using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class ArabTree:CompositeShape
    {
        public ArabTree(Point pt)
        {
            Point bottomRight = new Point(pt.X - 2, pt.Y - 20);
            Point mid = new Point(pt.X - 1, pt.Y - 20);
            Point top = new Point(mid.X, mid.Y - 26);
            Point rmid = new Point(pt.X + 14, mid.Y - 20);
            Point lmid = new Point(pt.X - 14, mid.Y - 20);
            Point rright = new Point(pt.X + 20, mid.Y - 10);
            Point lleft = new Point(pt.X - 20, mid.Y - 10);

            AddComponent(new Rectangle(pt, bottomRight));
            AddComponent(new Line(mid, top));
            AddComponent(new Line(mid, lmid));
            AddComponent(new Line(mid, rmid));
            AddComponent(new Line(mid, rright));
            AddComponent(new Line(mid, lleft));
        }
    }
}
