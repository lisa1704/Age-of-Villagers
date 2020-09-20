using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKingHouse : VillageComponent
    {
        public Point e;
        public EgyptianKingHouse(Point e)
        {
            this.e = e;

            Point point1 = new Point(e.X, e.Y);
            Point point2 = new Point(e.X+6, e.Y-7);
            Point point3 = new Point(e.X-3, e.Y-16);
            Point point4 = new Point(e.X-10, e.Y-4);

            addComponent(new Triangle(point1, point2, point3));
            addComponent(new Triangle(point1, point3, point4));
        }

        public override Point getPoint()
        {
            return e;
        }
    }
}
