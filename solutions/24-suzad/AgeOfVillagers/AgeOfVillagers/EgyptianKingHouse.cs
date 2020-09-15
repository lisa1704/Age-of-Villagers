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
        }
        public override void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x, y, x + 6, y - 7);
            graphics.DrawLine(pen, x + 6, y - 7, x - 3, y - 16);
            graphics.DrawLine(pen, x - 3, y - 16, x - 10, y - 4);
            graphics.DrawLine(pen, x - 10, y - 4, x, y);
            graphics.DrawLine(pen, x - 3, y - 16, x, y);
        }

        public override Point getPoint()
        {
            return e;
        }
    }
}
