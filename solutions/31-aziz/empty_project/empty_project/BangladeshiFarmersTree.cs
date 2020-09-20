using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    class BangladeshiFarmersTree : ITree
    {
        public void drawTree(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawEllipse(pen, axis.X, axis.Y, 16, 20);
            graphics.DrawRectangle(pen, axis.X + 7, axis.Y + 14, 2, 16);
        }
    }
}
