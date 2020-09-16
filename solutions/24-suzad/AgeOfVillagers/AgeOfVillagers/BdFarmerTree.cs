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
        }
        public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawArc(pen, x - 8, y - 8, 16, 16, 0, 360);
            graphics.DrawLine(pen, x - 1, y, x + 1, y);
            graphics.DrawLine(pen, x + 1, y, x + 1, y + 16);
            graphics.DrawLine(pen, x + 1, y + 16, x - 1, y + 16);
            graphics.DrawLine(pen, x - 1, y + 16, x - 1, y);
        }

        public override Point getPoint()
        {
            return e;
        }
    }
}
