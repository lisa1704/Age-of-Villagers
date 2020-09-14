using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BdFarmerRiver : IVillageComponent
    {
        public void drawComponent(Point e, Graphics graphics, Pen pen)
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
        }
    }
}
