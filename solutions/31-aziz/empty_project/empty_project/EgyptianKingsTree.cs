using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    class EgyptianKingsTree : ITree
    {
        public void drawTree(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X + 4, axis.Y - 20));
            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X - 4, axis.Y - 20));

            graphics.DrawLine(pen, new PointF(axis.X + 4, axis.Y - 20), new PointF(axis.X + 4, axis.Y - 24));
            graphics.DrawLine(pen, new PointF(axis.X + 4, axis.Y - 20), new PointF(axis.X + 8, axis.Y - 20));
            graphics.DrawLine(pen, new PointF(axis.X + 4, axis.Y - 20), new PointF(axis.X + 8, axis.Y - 24));

            graphics.DrawLine(pen, new PointF(axis.X - 4, axis.Y - 20), new PointF(axis.X - 4, axis.Y - 24));
            graphics.DrawLine(pen, new PointF(axis.X - 4, axis.Y - 20), new PointF(axis.X - 8, axis.Y - 20));
            graphics.DrawLine(pen, new PointF(axis.X - 4, axis.Y - 20), new PointF(axis.X - 8, axis.Y - 24));
        }
    }
}
