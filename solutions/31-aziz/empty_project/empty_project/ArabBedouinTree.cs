using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    class ArabBedouinTree : ITree
    {
        public void drawTree(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawRectangle(pen, axis.X, axis.Y, 2, 15);

            graphics.DrawLine(pen, new PointF(axis.X + 1, axis.Y), new PointF(axis.X + 1, axis.Y - 15));
            graphics.DrawLine(pen, new PointF(axis.X + 1, axis.Y), new PointF(axis.X + 4, axis.Y - 15));
            graphics.DrawLine(pen, new PointF(axis.X + 1, axis.Y), new PointF(axis.X + 6, axis.Y - 15));
            graphics.DrawLine(pen, new PointF(axis.X + 1, axis.Y), new PointF(axis.X + 8, axis.Y - 15));
            graphics.DrawLine(pen, new PointF(axis.X + 1, axis.Y), new PointF(axis.X - 3, axis.Y - 15));
            graphics.DrawLine(pen, new PointF(axis.X + 1, axis.Y), new PointF(axis.X - 5, axis.Y - 15));
            graphics.DrawLine(pen, new PointF(axis.X + 1, axis.Y), new PointF(axis.X - 7, axis.Y - 15));
        }
    }
}
