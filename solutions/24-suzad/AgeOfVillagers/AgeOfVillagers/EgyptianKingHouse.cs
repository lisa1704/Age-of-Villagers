using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianKingHouse : VillageComponent
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
        /*public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x, y, x + 6, y - 7);
            graphics.DrawLine(pen, x + 6, y - 7, x - 3, y - 16);
            graphics.DrawLine(pen, x - 3, y - 16, x - 10, y - 4);
            graphics.DrawLine(pen, x - 10, y - 4, x, y);
            graphics.DrawLine(pen, x - 3, y - 16, x, y);
        }*/

        public override Point getPoint()
        {
            return e;
        }
    }
}
