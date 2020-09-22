using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class EgyptianKingsTree : ITree
    {
        public void drawTree(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X + 8, axis.Y - 40));
            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X - 8, axis.Y - 40));

            graphics.DrawLine(pen, new PointF(axis.X + 8, axis.Y - 40), new PointF(axis.X + 8, axis.Y - 48));
            graphics.DrawLine(pen, new PointF(axis.X + 8, axis.Y - 40), new PointF(axis.X + 16, axis.Y - 40));
            graphics.DrawLine(pen, new PointF(axis.X + 8, axis.Y - 40), new PointF(axis.X + 16, axis.Y - 48));

            graphics.DrawLine(pen, new PointF(axis.X - 8, axis.Y - 40), new PointF(axis.X - 8, axis.Y - 48));
            graphics.DrawLine(pen, new PointF(axis.X - 8, axis.Y - 40), new PointF(axis.X - 16, axis.Y - 40));
            graphics.DrawLine(pen, new PointF(axis.X - 8, axis.Y - 40), new PointF(axis.X - 16, axis.Y - 48));
        }
    }
}
