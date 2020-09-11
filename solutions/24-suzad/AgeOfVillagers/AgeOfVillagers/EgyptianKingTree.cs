using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianKingTree : IVillageComponent
    {
        public void drawComponent(MouseEventArgs e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x, y, x + 3, y - 12);
            graphics.DrawLine(pen, x, y, x - 2, y - 12);
            graphics.DrawLine(pen, x + 3, y - 12, x + 8, y - 24);
            graphics.DrawLine(pen, x + 3, y - 12, x + 5, y - 24);
            graphics.DrawLine(pen, x + 3, y - 12, x + 2, y - 24);
            graphics.DrawLine(pen, x - 2, y - 12, x - 8, y - 24);
            graphics.DrawLine(pen, x - 2, y - 12, x - 4, y - 24);
            graphics.DrawLine(pen, x - 2, y - 12, x - 1, y - 24);
        }
    }
}
