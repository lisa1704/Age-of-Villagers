using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class ArabBedouinHouse : VillageComponent
    {
        public Point e;

        public ArabBedouinHouse(Point e)
        {
            this.e = e;

            Point point1 = new Point(e.X, e.Y);
            Point point2 = new Point(e.X+6, e.Y-8);
            Point point3 = new Point(e.X+2, e.Y-16);
            Point point4 = new Point(e.X-5, e.Y-10);
            Point point5 = new Point(e.X-10, e.Y);

            addComponent(new Quadrilateral(point1, point2, point3, point4));
            addComponent(new Triangle(point1, point4, point5));
        }

        public override Point getPoint()
        {
            return e;
        }
    }
}
