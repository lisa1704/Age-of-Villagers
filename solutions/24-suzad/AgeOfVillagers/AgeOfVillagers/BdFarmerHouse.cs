using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BdFarmerHouse : VillageComponent
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
        /*public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x, y, x + 16, y);
            graphics.DrawLine(pen, x + 16, y, x + 16, y + 8);
            graphics.DrawLine(pen, x + 16, y + 8, x, y + 8);
            graphics.DrawLine(pen, x, y + 8, x, y);
            graphics.DrawLine(pen, x, y, x + 8, y - 8);
            graphics.DrawLine(pen, x + 8, y - 8, x + 16, y);
        }*/

        public override Point getPoint()
        {
            return e;
        }
    }
}
