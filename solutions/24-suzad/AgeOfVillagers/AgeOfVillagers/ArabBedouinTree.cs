using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabBedouinTree : IVillageComponent
    {
        public void drawComponent(MouseEventArgs e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x - 1, y, x + 1, y);
            graphics.DrawLine(pen, x - 1, y, x - 1, y + 14);
            graphics.DrawLine(pen, x - 1, y + 14, x + 1, y + 14);
            graphics.DrawLine(pen, x + 1, y + 14, x + 1, y);
            graphics.DrawLine(pen, x + 1, y, x + 8, y - 10);
            graphics.DrawLine(pen, x, y, x + 4, y - 10);
            graphics.DrawLine(pen, x, y, x, y - 10);
            graphics.DrawLine(pen, x, y, x - 4, y - 10);
            graphics.DrawLine(pen, x - 1, y, x - 8, y - 10);
        }
    }
}
