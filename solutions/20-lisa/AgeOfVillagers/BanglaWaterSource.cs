using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BanglaWaterSource : CompositeShape
    {
        public BanglaWaterSource(Point fp)
        {
            Point p2 = new Point(fp.X - 25, fp.Y + 60);
            Point p3 = new Point(fp.X , fp.Y + 85);
            Point p4 = new Point(fp.X + 25, fp.Y + 60);
            Point p5 = new Point(fp.X + 60, fp.Y + 85);
            Point p6 = new Point(fp.X + 80, fp.Y + 35);
            Point p7 = new Point(fp.X + 60, fp.Y);
            Point p8 = new Point(fp.X + 35, fp.Y + 35);
            Point p9 = new Point(fp.X + 35, fp.Y);
            

            AddComponent(new Line(fp, p2));
            AddComponent(new Line(p2, p3));
            AddComponent(new Line(p3, p4));
            AddComponent(new Line(p4, p5));
            AddComponent(new Line(p5, p6));
            AddComponent(new Line(p6, p7));
            AddComponent(new Line(p7, p8));
            AddComponent(new Line(p8, p9));
            AddComponent(new Line(p9, fp));





        }
    }
}
