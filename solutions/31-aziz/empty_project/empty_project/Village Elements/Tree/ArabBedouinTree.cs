using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class ArabBedouinTree : ITree
    {
        public void drawTree(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X + 2, axis.Y));
            graphics.DrawLine(pen, new PointF(axis.X + 2, axis.Y), new PointF(axis.X + 2, axis.Y + 12));
            graphics.DrawLine(pen, new PointF(axis.X + 2, axis.Y + 12), new PointF(axis.X, axis.Y + 12));
            graphics.DrawLine(pen, new PointF(axis.X, axis.Y + 12), new PointF(axis.X, axis.Y));

            graphics.DrawLine(pen, new PointF(axis.X + 1, axis.Y), new PointF(axis.X + 1, axis.Y - 12));
            graphics.DrawLine(pen, new PointF(axis.X + 1, axis.Y), new PointF(axis.X + 9, axis.Y - 8));
            graphics.DrawLine(pen, new PointF(axis.X + 1, axis.Y), new PointF(axis.X + 14, axis.Y - 4));
            graphics.DrawLine(pen, new PointF(axis.X + 1, axis.Y), new PointF(axis.X - 6, axis.Y - 8));
            graphics.DrawLine(pen, new PointF(axis.X + 1, axis.Y), new PointF(axis.X - 11, axis.Y - 4));
        }
    }
}
