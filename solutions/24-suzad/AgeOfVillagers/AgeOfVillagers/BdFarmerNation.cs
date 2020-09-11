using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BdFarmerNation
    {
        public void houseDrawing(MouseEventArgs e, Graphics graphics,Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x, y, x+16, y);
            graphics.DrawLine(pen, x+16, y, x + 16, y+8);
            graphics.DrawLine(pen, x+16, y+8, x, y+8);
            graphics.DrawLine(pen, x, y+8, x, y);
            graphics.DrawLine(pen, x, y, x + 8, y-8);
            graphics.DrawLine(pen, x+8, y-8, x + 16, y);
        }
        public void treeDrawing(MouseEventArgs e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawArc(pen, x - 8, y - 8, 16, 16, 0, 360);
            graphics.DrawLine(pen, x - 1, y, x + 1, y);
            graphics.DrawLine(pen, x + 1, y, x + 1, y + 16);
            graphics.DrawLine(pen, x + 1, y + 16, x - 1, y+16);
            graphics.DrawLine(pen, x - 1, y+16, x - 1, y);
        }
    }
}
