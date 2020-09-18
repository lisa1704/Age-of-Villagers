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

            graphics.DrawEllipse(pen, axis.X, axis.Y, 20, 20);
            graphics.DrawEllipse(pen, axis.X + 8, axis.Y + 20, 4, 10);
        }
    }
}
