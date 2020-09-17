using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianKingRiver : VillageComponent
    {
        public Point e;
        public EgyptianKingRiver(Point e)
        {
            this.e = e;

            Point point = new Point(e.X - 6, e.Y - 6);
            int width = 12;
            int height = 12;

            addComponent(new Circle(point, height, width));
        }
        /*public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawArc(pen, x - 6, y - 6, 12, 12, 0, 360);
        }*/

        public override Point getPoint()
        {
            return e;
        }
    }
}
