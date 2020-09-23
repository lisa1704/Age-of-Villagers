using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class BangladeshiFarmersTree : ITree
    {
        public void drawTree(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawEllipse(pen, axis.X, axis.Y, 12, 16);
            graphics.DrawRectangle(pen, axis.X + 5, axis.Y + 11, 2, 12);
        }
    }
}
