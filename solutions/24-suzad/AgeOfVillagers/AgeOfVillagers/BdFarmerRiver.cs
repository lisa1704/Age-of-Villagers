using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BdFarmerRiver : VillageComponent
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
        /*public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x, y, x + 5, y + 4);
            graphics.DrawLine(pen, x + 5, y + 4, x + 11, y - 6);
            graphics.DrawLine(pen, x + 11, y - 6, x + 2, y - 11);
            graphics.DrawLine(pen, x + 2, y - 11, x - 4, y - 6);
            graphics.DrawLine(pen, x - 4, y - 6, x - 6, y - 9);
            graphics.DrawLine(pen, x - 6, y - 9, x - 9, y - 7);
            graphics.DrawLine(pen, x - 9, y - 7, x - 13, y);
            graphics.DrawLine(pen, x - 13, y, x - 6, y + 5);
            graphics.DrawLine(pen, x - 6, y + 5, x, y);
        }*/

        public override Point getPoint()
        {
            return e;
        }
    }
}
