using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabBedouinHouse : IVillageComponent
    {
        public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x, y, x + 6, y - 8);
            graphics.DrawLine(pen, x + 6, y - 8, x + 2, y - 16);
            graphics.DrawLine(pen, x + 2, y - 16, x - 5, y - 10);
            graphics.DrawLine(pen, x - 5, y - 10, x - 10, y);
            graphics.DrawLine(pen, x - 5, y - 10, x, y);
            graphics.DrawLine(pen, x - 10, y, x, y);
        }
    }
}
