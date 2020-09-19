using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabBedouinTree : VillageComponent
    {
        public Point e;
        public ArabBedouinTree(Point e)
        {
            this.e = e;

            Point point1 = new Point(e.X-1, e.Y);
            Point point2 = new Point(e.X+1, e.Y);
            Point point3 = new Point(e.X-1, e.Y+14);
            Point point4 = new Point(e.X+1, e.Y+14);
            Point point5 = new Point(e.X + 8, e.Y - 10);
            Point point6 = new Point(e.X + 4, e.Y - 10);
            Point point7 = new Point(e.X, e.Y);
            Point point8 = new Point(e.X, e.Y-10);
            Point point9 = new Point(e.X-4, e.Y-10);
            Point point10 = new Point(e.X - 8, e.Y - 10);

            addComponent(new Quadrilateral(point1, point2, point4, point3));
            addComponent(new Line(point2, point5));
            addComponent(new Line(point6, point7));
            addComponent(new Line(point7, point8));
            addComponent(new Line(point7, point9));
            addComponent(new Line(point1, point10));
        }

        public override Point getPoint()
        {
            return e;
        }
    }
}
