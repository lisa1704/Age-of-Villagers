using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdFarmerRiver : VillageComponent
    {
        public Point e;
        public BdFarmerRiver(Point e)
        {
            this.e = e;

            Point point1 = new Point(e.X, e.Y);
            Point point2 = new Point(e.X+5, e.Y+4);
            Point point3 = new Point(e.X+11, e.Y-6);
            Point point4 = new Point(e.X+2, e.Y-11);
            Point point5 = new Point(e.X-4, e.Y-6);
            Point point6 = new Point(e.X-6, e.Y-9);
            Point point7 = new Point(e.X-9, e.Y-7);
            Point point8 = new Point(e.X-13, e.Y);
            Point point9 = new Point(e.X-6, e.Y+5);

            addComponent(new Line(point1, point2));
            addComponent(new Line(point2, point3));
            addComponent(new Line(point3, point4));
            addComponent(new Line(point4, point5));
            addComponent(new Line(point5, point6));
            addComponent(new Line(point6, point7));
            addComponent(new Line(point7, point8));
            addComponent(new Line(point8, point9));
            addComponent(new Line(point9, point1));
        }

        public override Point getPoint()
        {
            return e;
        }
    }
}
