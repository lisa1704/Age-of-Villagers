using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BdFarmerTree : VillageComponent
    {
        public Point e;
        public BdFarmerTree(Point e)
        {
            this.e = e;

            Point point1 = new Point(e.X - 1, e.Y);
            Point point2 = new Point(e.X + 1, e.Y);
            Point point3 = new Point(e.X + 1, e.Y+16);
            Point point4 = new Point(e.X - 1, e.Y+16);
            Point point5 = new Point(e.X - 8, e.Y-8);

            addComponent(new Quadrilateral(point1, point2, point3, point4));
            addComponent(new Circle(point5, 16, 16));
        }
        /*public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawArc(pen, x - 8, y - 8, 16, 16, 0, 360);
            graphics.DrawLine(pen, x - 1, y, x + 1, y);
            graphics.DrawLine(pen, x + 1, y, x + 1, y + 16);
            graphics.DrawLine(pen, x + 1, y + 16, x - 1, y + 16);
            graphics.DrawLine(pen, x - 1, y + 16, x - 1, y);
        }*/

        public override Point getPoint()
        {
            return e;
        }
    }
}
