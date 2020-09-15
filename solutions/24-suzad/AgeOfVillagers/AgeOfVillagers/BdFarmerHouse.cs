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
        }
        public override void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x, y, x + 16, y);
            graphics.DrawLine(pen, x + 16, y, x + 16, y + 8);
            graphics.DrawLine(pen, x + 16, y + 8, x, y + 8);
            graphics.DrawLine(pen, x, y + 8, x, y);
            graphics.DrawLine(pen, x, y, x + 8, y - 8);
            graphics.DrawLine(pen, x + 8, y - 8, x + 16, y);
        }

        public override Point getPoint()
        {
            return e;
        }
    }
}
