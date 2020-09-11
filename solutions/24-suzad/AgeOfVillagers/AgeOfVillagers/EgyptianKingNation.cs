using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianKingNation
    {
        public void houseDrawing(MouseEventArgs e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x, y, x + 6, y-7);
            graphics.DrawLine(pen, x + 6, y-7, x-3, y-16);
            graphics.DrawLine(pen, x-3, y-16, x-10, y-4);
            graphics.DrawLine(pen, x-10, y-4, x, y);
            graphics.DrawLine(pen, x-3, y-16, x, y);
        }
        public void treeDrawing(MouseEventArgs e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x, y, x + 3, y-12);
            graphics.DrawLine(pen, x, y, x-2, y-12);
            graphics.DrawLine(pen, x + 3, y-12, x+8, y-24);
            graphics.DrawLine(pen, x+3, y-12, x+5, y-24);
            graphics.DrawLine(pen, x + 3, y - 12, x + 2, y - 24);
            graphics.DrawLine(pen, x-2, y - 12, x-8, y - 24);
            graphics.DrawLine(pen, x-2, y - 12, x-4, y - 24);
            graphics.DrawLine(pen, x - 2, y - 12, x - 1, y - 24);
        }
        public void riverDrawing(MouseEventArgs e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawArc(pen, x - 6, y - 6, 12, 12, 0, 360);
        }
    }
}
