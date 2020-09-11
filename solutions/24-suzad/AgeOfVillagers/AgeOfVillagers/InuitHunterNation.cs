using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InuitHunterNation
    {
        public void houseDrawing(MouseEventArgs e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x, y, x + 16, y);
            graphics.DrawArc(pen, x, y-16, 16, 32, 180, 180);
            graphics.DrawArc(pen, x+5, y-6, 6, 12, 180, 180);
        }
    }
}
