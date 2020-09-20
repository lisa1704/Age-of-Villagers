using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class InuitHunterHouse : VillageComponent
    {
        public Point e;
        public InuitHunterHouse(Point e)
        {
            this.e = e;

            Point linePoint1 = new Point(e.X, e.Y);
            Point linePoint2 = new Point(e.X+16, e.Y);
            Point arcPoint1 = new Point(e.X, e.Y-16);
            int height1 = 32;
            int width1 = 16;

            Point linePoint3 = new Point(e.X+5, e.Y);
            Point linePoint4 = new Point(e.X + 12, e.Y);
            Point arcPoint2 = new Point(e.X+5, e.Y - 6);
            int height2 = 12;
            int width2 = 6;

            addComponent(new SemiCircle(arcPoint1, linePoint1, linePoint2, height1, width1));
            addComponent(new SemiCircle(arcPoint2, linePoint3, linePoint4, height2, width2));
        }

        public override Point getPoint()
        {
            return e;
        }
    }
}
