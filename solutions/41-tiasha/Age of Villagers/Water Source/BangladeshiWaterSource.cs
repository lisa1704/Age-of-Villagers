using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class BangladeshiWaterSource : CompositeShape
    {
        public BangladeshiWaterSource(Point p, ElementSize sz)
        {
            Point p1, p2, p3, p4, p5, p6, p7, p8, p9;
            p1 = new Point(p.X + sz.width / 2, p.Y);
            p2 = new Point(p1.X - sz.width / 4, p.Y);
            p3 = new Point(p.X, p.Y + sz.height / 2);
            p4 = new Point(p2.X, p.Y + sz.height);
            p5 = new Point(p4.X + sz.height / 4, p3.Y + 4);
            p6 = new Point(p5.X + sz.height / 4, p4.Y);
            p7 = new Point(p.X + sz.width, p5.Y);
            p8 = new Point(p7.X - sz.width / 3, p.Y);
            p9 = new Point(p1.X, p3.Y);

            AddComponent(new Line(p1.X, p1.Y, p2.X, p2.Y));
            AddComponent(new Line(p2.X, p2.Y, p3.X, p3.Y));
            AddComponent(new Line(p3.X, p3.Y, p4.X, p4.Y));
            AddComponent(new Line(p4.X, p4.Y, p5.X, p5.Y));
            AddComponent(new Line(p5.X, p5.Y, p6.X, p6.Y));
            AddComponent(new Line(p6.X, p6.Y, p7.X, p7.Y));
            AddComponent(new Line(p7.X, p7.Y, p8.X, p8.Y));
            AddComponent(new Line(p8.X, p8.Y, p9.X, p9.Y));
            AddComponent(new Line(p9.X, p9.Y, p1.X, p1.Y));
        }
    }
}
