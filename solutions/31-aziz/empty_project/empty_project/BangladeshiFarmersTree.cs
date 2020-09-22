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

            graphics.DrawEllipse(pen, axis.X, axis.Y, 32, 40);
            graphics.DrawRectangle(pen, axis.X + 14, axis.Y + 28, 4, 32);
        }
    }
}
