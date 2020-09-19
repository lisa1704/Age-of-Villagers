using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdFarmerHouse : VillageComponent
    {
        public Point e;
        public BdFarmerHouse(Point e)
        {
            this.e = e;

            Point point1 = new Point(e.X,e.Y);
            Point point2 = new Point(e.X+16, e.Y);
            Point point3 = new Point(e.X+16, e.Y+8);
            Point point4 = new Point(e.X, e.Y+8);
            Point point5 = new Point(e.X + 8, e.Y - 8);

            addComponent(new Quadrilateral(point1, point2, point3, point4));
            addComponent(new Triangle(point1, point2, point5));
        }

        public override Point getPoint()
        {
            return e;
        }
    }
}
