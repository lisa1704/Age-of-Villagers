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

            graphics.DrawRectangle(pen, axis.X, axis.Y, 4, 30);

            graphics.DrawLine(pen, new PointF(axis.X + 2, axis.Y), new PointF(axis.X + 2, axis.Y - 30));
            graphics.DrawLine(pen, new PointF(axis.X + 2, axis.Y), new PointF(axis.X + 18, axis.Y - 20));
            graphics.DrawLine(pen, new PointF(axis.X + 2, axis.Y), new PointF(axis.X + 28, axis.Y - 10));
            graphics.DrawLine(pen, new PointF(axis.X + 2, axis.Y), new PointF(axis.X - 12, axis.Y - 20));
            graphics.DrawLine(pen, new PointF(axis.X + 2, axis.Y), new PointF(axis.X - 22, axis.Y - 10));
        }
    }
}
